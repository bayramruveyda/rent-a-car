using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarRentalLogin
{
    public partial class CustomersForm : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {
            // boş
        }

        private int? selectedCustomerId = null;

        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomers();

            // İstersen garanti olsun diye (Designer'da bağlı olmasa bile çalışır)
            dgvCustomers.CellClick += dgvCustomers_CellClick;
        }

        // ==================== MÜŞTERİLERİ LİSTELE ====================
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
                            FullName  AS 'Ad Soyad',
                            Phone     AS 'Telefon',
                            Email     AS 'E-posta',
                            TcNo      AS 'TC No',
                            LicenseNo AS 'Ehliyet No',
                            CASE 
                                WHEN IsActive = 1 THEN 'Aktif' 
                                ELSE 'Pasif' 
                            END       AS 'Durum'
                        FROM Customers;";

                    using (var da = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCustomers.DataSource = dt;
                    }
                }

                dgvCustomers.ClearSelection();
                selectedCustomerId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken hata: " + ex.Message);
            }
        }

        // ==================== FORMU TEMİZLE ====================
        private void ClearForm()
        {
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtTcNo.Text = "";
            txtLicenseNo.Text = "";
            chkActive.Checked = true;

            selectedCustomerId = null;
        }

        // ==================== VERİ DOĞRULAMA ====================
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Ad Soyad zorunludur!");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTcNo.Text))
            {
                if (txtTcNo.Text.Length != 11 || !long.TryParse(txtTcNo.Text, out _))
                {
                    MessageBox.Show("TC No 11 haneli sayı olmalıdır!");
                    return false;
                }
            }

            return true;
        }

        // ==================== TABLOYA TIKLAMA ====================
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCustomers.Rows[e.RowIndex];

            selectedCustomerId = Convert.ToInt32(row.Cells["Id"].Value);

            txtFullName.Text = row.Cells["Ad Soyad"].Value?.ToString();
            txtPhone.Text = row.Cells["Telefon"].Value?.ToString();
            txtEmail.Text = row.Cells["E-posta"].Value?.ToString();
            txtTcNo.Text = row.Cells["TC No"].Value?.ToString();
            txtLicenseNo.Text = row.Cells["Ehliyet No"].Value?.ToString();
            chkActive.Checked = row.Cells["Durum"].Value?.ToString() == "Aktif";
        }

        // ==================== EKLE BUTONU ====================
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO Customers
                            (FullName, Phone, Email, TcNo, LicenseNo, IsActive)
                        VALUES
                            (@FullName, @Phone, @Email, @TcNo, @LicenseNo, @IsActive);";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                        cmd.Parameters.AddWithValue("@LicenseNo", txtLicenseNo.Text);
                        cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri eklendi!");
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (ekleme): " + ex.Message);
            }
        }

        // ==================== GÜNCELLE BUTONU ====================
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == null)
            {
                MessageBox.Show("Güncellemek için tablodan bir müşteri seç!");
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Customers SET
                            FullName  = @FullName,
                            Phone     = @Phone,
                            Email     = @Email,
                            TcNo      = @TcNo,
                            LicenseNo = @LicenseNo,
                            IsActive  = @IsActive
                        WHERE Id = @Id;";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                        cmd.Parameters.AddWithValue("@LicenseNo", txtLicenseNo.Text);
                        cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Id", selectedCustomerId.Value);

                        int affected = cmd.ExecuteNonQuery();

                        if (affected > 0)
                            MessageBox.Show("Müşteri güncellendi!");
                        else
                            MessageBox.Show("Güncellenecek kayıt bulunamadı!");
                    }
                }

                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (güncelle): " + ex.Message);
            }
        }

        // ==================== SİL BUTONU ====================
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == null)
            {
                MessageBox.Show("Silmek için tablodan bir müşteri seç!");
                return;
            }

            var confirm = MessageBox.Show("Seçili müşteriyi silmek istiyor musun?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM Customers WHERE Id = @Id;";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedCustomerId.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri silindi!");
                ClearForm();
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (sil): " + ex.Message);
            }
        }

        // ==================== TEMİZLE BUTONU ====================
        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            // İstersen buraya LoadCustomers() yazabilirsin ama zaten constructor'da çağırıyorsun.
        }
    }
}
