using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRentalLogin
{
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();

            // Yılları yükle ve seçilen yıl için grafiği çiz
            LoadYears();
        }

        // =================== YIL LİSTESİNİ YÜKLE ===================
        private void LoadYears()
        {
            cmbYear.Items.Clear();

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Rentals tablosundaki farklı yılları çekiyoruz
                    string sql = @"
                        SELECT DISTINCT strftime('%Y', StartDate) AS Yil
                        FROM Rentals
                        ORDER BY Yil;
                    ";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string year = reader["Yil"].ToString();
                            if (!string.IsNullOrEmpty(year))
                                cmbYear.Items.Add(year);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yıllar yüklenirken hata: " + ex.Message);
            }

            // Hiç yıl yoksa bile en azından şimdiki yılı göster
            string currentYear = DateTime.Now.Year.ToString();
            if (cmbYear.Items.Count == 0)
            {
                cmbYear.Items.Add(currentYear);
            }

            // Varsayılan olarak güncel yılı seç
            if (cmbYear.Items.Contains(currentYear))
                cmbYear.SelectedItem = currentYear;
            else
                cmbYear.SelectedIndex = 0; // elde ne varsa onu seç

            // Seçili yıl için grafiği çiz
            if (cmbYear.SelectedItem != null)
            {
                LoadMonthlyRevenueChart(cmbYear.SelectedItem.ToString());
            }
        }

        // =================== GRAFİĞİ ÇİZ ===================
        private void LoadMonthlyRevenueChart(string year)
        {
            // Chart temizle
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();

            // Başlık
            chartRevenue.Titles.Add("Aylık Gelir Grafiği - " + year);

            // Seri oluştur
            Series series = chartRevenue.Series.Add("Aylık Gelir");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            // Eksen başlıkları
            chartRevenue.ChartAreas[0].AxisX.Title = "Ay";
            chartRevenue.ChartAreas[0].AxisY.Title = "Toplam Gelir (₺)";

            // Türkçe ay isimleri
            string[] monthNames = { "Oca", "Şub", "Mar", "Nis", "May", "Haz", "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara" };

            // 1️⃣ Önce tüm aylar için 0 gelirli bir dizi/dictionary hazırlayalım
            decimal[] monthlyRevenue = new decimal[13]; // 1..12 kullanılacak, 0 boş

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Seçilen yıl için aylık toplam geliri çek
                    string sql = @"
                        SELECT 
                            strftime('%m', StartDate) AS Ay,
                            SUM(TotalPrice)          AS ToplamGelir
                        FROM Rentals
                        WHERE Status = 'Tamamlandı'
                          AND strftime('%Y', StartDate) = @Year
                        GROUP BY strftime('%m', StartDate)
                        ORDER BY Ay;
                    ";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string monthStr = reader["Ay"].ToString();   // "01".."12"
                                if (!int.TryParse(monthStr, out int month))
                                    continue;

                                if (!decimal.TryParse(reader["ToplamGelir"].ToString(), out decimal total))
                                    continue;

                                // ilgili ayın gelirini doldur
                                monthlyRevenue[month] = total;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grafik verileri yüklenirken hata: " + ex.Message);
            }

            // 2️⃣ 12 ayı da grafiğe ekle (kiralama yoksa değer 0)
            for (int month = 1; month <= 12; month++)
            {
                string label = $"{monthNames[month - 1]} {year}";
                series.Points.AddXY(label, monthlyRevenue[month]);
            }
        }

        // ============== YIL DEĞİŞTİĞİNDE GRAFİĞİ GÜNCELLE ==============
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedItem == null)
                return;

            string year = cmbYear.SelectedItem.ToString();
            LoadMonthlyRevenueChart(year);
        }

        private void chartRevenue_Click(object sender, EventArgs e)
        {
            // Grafiğe tıklanınca hiçbir şey yapma
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
