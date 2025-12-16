using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarRentalLogin
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            // Durum filtre seçenekleri
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("Tümü");
            cmbStatusFilter.Items.Add("Aktif");
            cmbStatusFilter.Items.Add("Tamamlandı");
            cmbStatusFilter.SelectedIndex = 0;

            // Tarih filtrelerini şimdilik kapalı başlatalım
            chkUseDate.Checked = false;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;

            dtpFrom.Value = DateTime.Today.AddMonths(-1); // Son 1 ay
            dtpTo.Value = DateTime.Today;

            // Grid ayarları
            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // İlk açılışta tüm kiralamaları yükle
            LoadReports();
        }

        // ================== RAPOR YÜKLEME ==================

        private void LoadReports(string statusFilter = "Tümü", bool useDate = false, DateTime? from = null, DateTime? to = null)
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
                        JOIN Cars c         ON r.CarId      = c.Id
                        JOIN Customers cust ON r.CustomerId = cust.Id
                        WHERE 1 = 1
                    ";

                    using (var cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;

                        // Duruma göre filtre
                        if (statusFilter != "Tümü")
                        {
                            sql += " AND r.Status = @Status";
                            cmd.Parameters.AddWithValue("@Status", statusFilter);
                        }

                        // Tarihe göre filtre
                        if (useDate && from.HasValue && to.HasValue)
                        {
                            sql += " AND r.StartDate >= @FromDate AND r.EndDate <= @ToDate";
                            cmd.Parameters.AddWithValue("@FromDate", from.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@ToDate", to.Value.ToString("yyyy-MM-dd"));
                        }

                        sql += " ORDER BY r.StartDate DESC;";

                        cmd.CommandText = sql;

                        using (var da = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvReports.DataSource = dt;
                        }
                    }
                }

                UpdateTotalRevenue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar yüklenirken hata: " + ex.Message);
            }
        }

        // ================== TOPLAM GELİR HESABI ==================

        private void UpdateTotalRevenue()
        {
            decimal total = 0;

            if (dgvReports.DataSource is DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Toplam Ücret"] != DBNull.Value &&
                        decimal.TryParse(row["Toplam Ücret"].ToString(), out decimal value))
                    {
                        total += value;
                    }
                }
            }

            lblTotalRevenue.Text = $"Toplam Gelir: {total:0.00} ₺";
        }

        // ================== EVENTLER ==================

        private void chkUseDate_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkUseDate.Checked;
            dtpFrom.Enabled = enabled;
            dtpTo.Enabled = enabled;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "Tümü";
            bool useDate = chkUseDate.Checked;
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            LoadReports(status, useDate, from, to);
        }
    }
}
