using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarRentalLogin
{
    public partial class CarsForm : Form
    {
        // Seçilen aracın Id'si
        private int? selectedCarId = null;

        public CarsForm()
        {
            InitializeComponent();

            // Form açılınca listeyi yükle
            LoadCars();

            // Özellikle DataGridView için event'i garanti altına alıyoruz
            dgvCars.CellClick += dgvCars_CellClick;
        }

        // Designer'da forma bağlı olabilecek Load eventi için
        private void CarsForm_Load(object sender, EventArgs e)
        {
            // Zaten constructor içinde LoadCars() çağırıyoruz.
            // İstersen buraya ekstra şeyler ekleyebilirsin.
        }

        // =============== ARAÇLARI LİSTELE ===============
        private void LoadCars()
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            Id,
                            Brand AS 'Marka',
                            Model AS 'Model',
                            Plate AS 'Plaka',
                            Year AS 'Yıl',
                            DailyPrice AS 'Günlük Ücret',
                            CASE WHEN IsAvailable = 1 THEN 'Müsait' ELSE 'Dolu' END AS 'Durum'
                        FROM Cars;";

                    using (var da = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCars.DataSource = dt;
                    }
                }

                dgvCars.ClearSelection();
                selectedCarId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araçlar yüklenirken hata: " + ex.Message);
            }
        }

        // =============== FORM TEMİZLE ===============
        private void ClearForm()
        {
            txtBrand.Text = "";
            txtModel.Text = "";
            txtPlate.Text = "";
            txtYear.Text = "";
            txtDailyPrice.Text = "";
            chkAvailable.Checked = true;

            selectedCarId = null;
            dgvCars.ClearSelection();
        }

        // =============== VERİ DOĞRULAMA ===============
        private bool ValidateInputs()
        {
            if (txtBrand.Text == "" ||
                txtModel.Text == "" ||
                txtPlate.Text == "" ||
                txtDailyPrice.Text == "")
            {
                MessageBox.Show("Marka, Model, Plaka ve Günlük Ücret zorunludur!");
                return false;
            }

            if (txtYear.Text != "" && !int.TryParse(txtYear.Text, out _))
            {
                MessageBox.Show("Yıl sayısal olmalıdır!");
                return false;
            }

            if (!double.TryParse(txtDailyPrice.Text, out _))
            {
                MessageBox.Show("Günlük Ücret sayısal olmalıdır!");
                return false;
            }

            return true;
        }

        // =============== EKLE BUTONU ===============
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO Cars (Brand, Model, Plate, Year, DailyPrice, IsAvailable)
                        VALUES (@Brand, @Model, @Plate, @Year, @DailyPrice, @IsAvailable);";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@Plate", txtPlate.Text);

                        if (txtYear.Text == "")
                            cmd.Parameters.AddWithValue("@Year", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));

                        cmd.Parameters.AddWithValue("@DailyPrice", double.Parse(txtDailyPrice.Text));
                        cmd.Parameters.AddWithValue("@IsAvailable", chkAvailable.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Araç eklendi!");
                ClearForm();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (ekleme): " + ex.Message);
            }
        }

        // =============== TABLOYA TIKLAMA ===============
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCars.Rows[e.RowIndex];

            // Id kolonundan primary key
            selectedCarId = Convert.ToInt32(row.Cells["Id"].Value);

            txtBrand.Text = row.Cells["Marka"].Value?.ToString();
            txtModel.Text = row.Cells["Model"].Value?.ToString();
            txtPlate.Text = row.Cells["Plaka"].Value?.ToString();
            txtYear.Text = row.Cells["Yıl"].Value?.ToString();
            txtDailyPrice.Text = row.Cells["Günlük Ücret"].Value?.ToString();
            chkAvailable.Checked = row.Cells["Durum"].Value?.ToString() == "Müsait";
        }

        // ================= ORTAK GÜNCELLEME İŞLEMİ =================
        private void DoUpdate()
        {
            if (selectedCarId == null)
            {
                MessageBox.Show("Lütfen listeden bir araç seçin!");
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Cars
                        SET Brand=@Brand, 
                            Model=@Model, 
                            Plate=@Plate, 
                            Year=@Year,
                            DailyPrice=@DailyPrice, 
                            IsAvailable=@IsAvailable
                        WHERE Id=@Id;";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@Plate", txtPlate.Text);

                        if (txtYear.Text == "")
                            cmd.Parameters.AddWithValue("@Year", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));

                        cmd.Parameters.AddWithValue("@DailyPrice", double.Parse(txtDailyPrice.Text));
                        cmd.Parameters.AddWithValue("@IsAvailable", chkAvailable.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Id", selectedCarId.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Araç güncellendi!");
                ClearForm();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (güncelleme): " + ex.Message);
            }
        }

        // Designer bazen btnUpdateCar_Click, bazen btnUpdateCar_Click_1 kullanmış olabilir.
        private void btnUpdateCar_Click(object sender, EventArgs e) => DoUpdate();
        private void btnUpdateCar_Click_1(object sender, EventArgs e) => DoUpdate();

        // ================= ORTAK SİLME İŞLEMİ =================
        private void DoDelete()
        {
            if (selectedCarId == null)
            {
                MessageBox.Show("Lütfen listeden bir araç seçin!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu aracı silmek istediğinize emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM Cars WHERE Id=@Id;";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedCarId.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Araç silindi!");
                ClearForm();
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (silme): " + ex.Message);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e) => DoDelete();
        private void btnDeleteCar_Click_1(object sender, EventArgs e) => DoDelete();

        // ================= ORTAK TEMİZLEME İŞLEMİ =================
        private void DoClear()
        {
            ClearForm();
        }

        private void btnClearCar_Click(object sender, EventArgs e) => DoClear();
        private void btnClearCar_Click_1(object sender, EventArgs e) => DoClear();

        // Designer'da bağlı olabilir diye boş bırakılmış event
        private void txtPlate_TextChanged(object sender, EventArgs e)
        {
            // Şimdilik bir şey yapmıyoruz; sadece hata çıkmasın diye var.
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
