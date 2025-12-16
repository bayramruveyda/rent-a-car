using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarRentalLogin
{
    public partial class RentalsForm : Form
    {
        private int? selectedRentalId = null;

        public RentalsForm()
        {
            InitializeComponent();

            // Tarihi geçmiş kiralamaları otomatik tamamla
            AutoCompleteExpiredRentals();

            // Başlangıç değerleri
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);

            LoadCars();
            LoadCustomers();
            LoadRentals();
        }

        // ===================== OTOMATİK TESLİM =====================

        private void AutoCompleteExpiredRentals()
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        // 1) Süresi bitmiş aktif kiralamaları tamamla
                        string completeSql = @"
UPDATE Rentals
SET Status = 'Tamamlandı'
WHERE Status = 'Aktif'
  AND date(EndDate) < date('now');";

                        using (var cmd = new SQLiteCommand(completeSql, conn, tran))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // 2) Araçların IsAvailable alanını güncelle
                        string carSql = @"
UPDATE Cars
SET IsAvailable = CASE 
    WHEN Id IN (SELECT CarId FROM Rentals WHERE Status = 'Aktif')
    THEN 0
    ELSE 1
END;";

                        using (var cmdCars = new SQLiteCommand(carSql, conn, tran))
                        {
                            cmdCars.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarihi geçmiş kiralamalar güncellenirken hata: " + ex.Message);
            }
        }

        // ===================== YARDIMCI METOTLAR =====================

        private void LoadCars()
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // SADECE MÜSAİT araçlar gelsin (IsAvailable = 1)
                    string sql = @"
                        SELECT 
                            Id,
                            Brand || ' ' || Model || ' - ' || Plate AS Display,
                            DailyPrice
                        FROM Cars
                        WHERE IsAvailable = 1;";

                    using (var da = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCars.DataSource = dt;
                        cmbCars.DisplayMember = "Display";
                        cmbCars.ValueMember = "Id";
                        cmbCars.SelectedIndex = -1;
                    }
                }

                txtDailyPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araçlar yüklenirken hata: " + ex.Message);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            Id,
                            FullName
                        FROM Customers
                        WHERE IsActive = 1;";

                    using (var da = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCustomers.DataSource = dt;
                        cmbCustomers.DisplayMember = "FullName";
                        cmbCustomers.ValueMember = "Id";
                        cmbCustomers.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken hata: " + ex.Message);
            }
        }

        private void LoadRentals()
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            r.Id,
                            c.Brand || ' ' || c.Model || ' - ' || c.Plate AS Araç,
                            cust.FullName AS Müşteri,
                            r.StartDate   AS 'Başlangıç',
                            r.EndDate     AS 'Bitiş',
                            r.DailyPrice  AS 'Günlük Ücret',
                            r.TotalPrice  AS 'Toplam Ücret',
                            r.Status      AS Durum
                        FROM Rentals r
                        JOIN Cars c         ON r.CarId = c.Id
                        JOIN Customers cust ON r.CustomerId = cust.Id;";

                    using (var da = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRentals.DataSource = dt;
                    }
                }

                dgvRentals.ClearSelection();
                selectedRentalId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiralama listesi yüklenirken hata: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            cmbCars.SelectedIndex = -1;
            cmbCustomers.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);
            txtDailyPrice.Text = "";
            txtTotalPrice.Text = "";
            selectedRentalId = null;
        }

        private void RecalculateTotal()
        {
            if (!decimal.TryParse(txtDailyPrice.Text, out decimal dailyPrice))
            {
                txtTotalPrice.Text = "";
            }
            else
            {
                int days = (int)(dtpEndDate.Value.Date - dtpStartDate.Value.Date).TotalDays;
                if (days <= 0)
                    days = 1;

                decimal total = dailyPrice * days;
                txtTotalPrice.Text = total.ToString("0.00");
            }
        }

        private bool ValidateInputs()
        {
            if (cmbCars.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir araç seçin!");
                return false;
            }

            if (cmbCustomers.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return false;
            }

            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz!");
                return false;
            }

            if (!decimal.TryParse(txtDailyPrice.Text, out _))
            {
                MessageBox.Show("Günlük ücret sayısal olmalıdır!");
                return false;
            }

            if (!decimal.TryParse(txtTotalPrice.Text, out _))
            {
                MessageBox.Show("Toplam ücret sayısal olmalıdır! Önce Ücret Hesapla'ya basın.");
                return false;
            }

            return true;
        }

        // ===================== EVENTLER =====================

        // Araç seçimi değişince – sadece fiyat yaz, uyarı yok
        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem is DataRowView row)
            {
                txtDailyPrice.Text = row["DailyPrice"]?.ToString();
            }
            else
            {
                txtDailyPrice.Text = "";
            }

            // Toplam ücreti sıfırla, kullanıcı tekrar hesaplasın
            txtTotalPrice.Text = "";
        }

        // Tasarımda yanlışlıkla bağlı olan label2_Click
        private void label2_Click(object sender, EventArgs e)
        {
            // Boş bırakıyoruz.
        }

        // Ücret Hesapla butonu
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            RecalculateTotal();
        }

        // Tarih değiştikçe toplamı sıfırla
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "";
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "";
        }

        // Günlük ücret değişince toplamı sıfırla
        private void txtDailyPrice_TextChanged(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "";
        }

        // Kaydet butonu (yeni kiralama) – tarih çakışma kontrolü yine duruyor
        private void btnAddRental_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    using (var tran = conn.BeginTransaction())
                    {
                        int carId = Convert.ToInt32(cmbCars.SelectedValue);

                        // Aynı araç için tarih çakışması var mı?
                        string checkSql = @"
                            SELECT COUNT(*)
                            FROM Rentals
                            WHERE CarId = @CarId
                              AND Status = 'Aktif'
                              AND NOT (
                                    @EndDate < StartDate 
                                    OR @StartDate > EndDate
                              );";

                        using (var checkCmd = new SQLiteCommand(checkSql, conn, tran))
                        {
                            checkCmd.Parameters.AddWithValue("@CarId", carId);
                            checkCmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date.ToString("yyyy-MM-dd"));
                            checkCmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.ToString("yyyy-MM-dd"));

                            long conflict = (long)checkCmd.ExecuteScalar();

                            if (conflict > 0)
                            {
                                MessageBox.Show("Bu araç seçilen tarihlerde zaten kiralanmış! Lütfen başka bir tarih seçin.");
                                tran.Rollback();
                                return;
                            }
                        }

                        // Rentals tablosuna ekle
                        string insertSql = @"
                            INSERT INTO Rentals
                                (CarId, CustomerId, StartDate, EndDate, DailyPrice, TotalPrice, Status)
                            VALUES
                                (@CarId, @CustomerId, @StartDate, @EndDate, @DailyPrice, @TotalPrice, @Status);";

                        using (var cmd = new SQLiteCommand(insertSql, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@CarId", carId);
                            cmd.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(cmbCustomers.SelectedValue));
                            cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@DailyPrice", decimal.Parse(txtDailyPrice.Text));
                            cmd.Parameters.AddWithValue("@TotalPrice", decimal.Parse(txtTotalPrice.Text));
                            cmd.Parameters.AddWithValue("@Status", "Aktif");
                            cmd.ExecuteNonQuery();
                        }

                        // Aracı müsait değil yap
                        string updateCarSql = "UPDATE Cars SET IsAvailable = 0 WHERE Id = @CarId;";
                        using (var carCmd = new SQLiteCommand(updateCarSql, conn, tran))
                        {
                            carCmd.Parameters.AddWithValue("@CarId", carId);
                            carCmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                }

                MessageBox.Show("Kiralama kaydedildi!");
                ClearForm();
                LoadCars();    // artık listede o araç görünmeyecek
                LoadRentals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiralama kaydedilirken hata: " + ex.Message);
            }
        }

        // Grid'e tıklayınca satırı seç
        private void dgvRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvRentals.Rows[e.RowIndex];

            if (row.Cells["Id"].Value == null)
            {
                selectedRentalId = null;
                return;
            }

            selectedRentalId = Convert.ToInt32(row.Cells["Id"].Value);
        }

        // Teslim Al butonu
        private void btnCloseRental_Click(object sender, EventArgs e)
        {
            if (selectedRentalId == null)
            {
                MessageBox.Show("Lütfen listeden bir kiralama seçin!");
                return;
            }

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    using (var tran = conn.BeginTransaction())
                    {
                        // Kiralamanın durumunu değiştir
                        string updateRentalSql = @"
                            UPDATE Rentals
                            SET Status = 'Tamamlandı'
                            WHERE Id = @Id;";

                        using (var cmd = new SQLiteCommand(updateRentalSql, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Id", selectedRentalId.Value);
                            cmd.ExecuteNonQuery();
                        }

                        // İlgili aracı tekrar müsait yap
                        string freeCarSql = @"
                            UPDATE Cars
                            SET IsAvailable = 1
                            WHERE Id = (
                                SELECT CarId FROM Rentals WHERE Id = @Id
                            );";

                        using (var carCmd = new SQLiteCommand(freeCarSql, conn, tran))
                        {
                            carCmd.Parameters.AddWithValue("@Id", selectedRentalId.Value);
                            carCmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                }

                MessageBox.Show("Araç teslim alındı, kiralama tamamlandı.");
                ClearForm();
                LoadCars();
                LoadRentals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teslim alma sırasında hata: " + ex.Message);
            }
        }

        // Temizle butonu
        private void btnClearRental_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void RentalsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
