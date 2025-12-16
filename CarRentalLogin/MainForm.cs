using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace CarRentalLogin
{
    public partial class MainForm : Form
    {
        private Form activeChildForm = null;
        private Control dashboardContent = null;

        // Renkler
        private readonly Color passiveColor = Color.FromArgb(120, 135, 150);  // gri
        private readonly Color activeColor = Color.DarkOrange;               // aktif turuncu
        private readonly Color hoverColor = Color.FromArgb(255, 180, 90);   // hover açık turuncu

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Araç Kiralama Otomasyonu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 580);
            this.MinimumSize = new Size(950, 550);

            this.BackColor = Color.FromArgb(255, 245, 250);
            this.Font = new Font("Segoe UI", 10F);

            panelContent.Dock = DockStyle.Fill;

            if (panelContent.Controls.Count > 0)
                dashboardContent = panelContent.Controls[0];

            // Menü butonlarını stil et
            StyleMenu(btnMainMenu);
            StyleMenu(btnCars);
            StyleMenu(btnCustomers);
            StyleMenu(btnRent);
            StyleMenu(btnReports);
            StyleMenu(btnCharts);
            StyleMenu(btnExit);

            // ✅ İlk açılış: Dashboard + Ana Menü aktif
            ShowDashboard();
            SetActiveMenu(btnMainMenu);

            // ✅ Açılışta focus menü butonlarına gitmesin (turuncu görünme sorunu biter)
            this.ActiveControl = null;
            panelContent.Select();
        }

        private void StyleMenu(BunifuButton btn)
        {
            if (btn == null) return;

            btn.TabStop = false; // ✅ butonlar klavye odağı almasın

            btn.IdleBorderThickness = 0;
            btn.IdleBorderRadius = 10;
            btn.IdleBorderColor = Color.Transparent;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);

            ApplyColors(btn, isActive: false);
        }

        private void ApplyColors(BunifuButton btn, bool isActive)
        {
            if (btn == null) return;

            // Idle
            btn.OnIdleState.FillColor = isActive ? activeColor : passiveColor;
            btn.OnIdleState.ForeColor = Color.White;

            // 🔒 Hover
            if (isActive)
                btn.onHoverState.FillColor = hoverColor;   // SADECE aktif hover alır
            else
                btn.onHoverState.FillColor = passiveColor; // pasif hover kapalı

            btn.onHoverState.ForeColor = Color.White;

            // Pressed
            btn.OnPressedState.FillColor = activeColor;
            btn.OnPressedState.ForeColor = Color.White;

            // Disabled
            btn.OnDisabledState.FillColor = passiveColor;
            btn.OnDisabledState.ForeColor = Color.White;
        }


        private void SetActiveMenu(BunifuButton activeBtn)
        {
            ApplyColors(btnMainMenu, false);
            ApplyColors(btnCars, false);
            ApplyColors(btnCustomers, false);
            ApplyColors(btnRent, false);
            ApplyColors(btnReports, false);
            ApplyColors(btnCharts, false);
            ApplyColors(btnExit, false);

            if (activeBtn != null)
                ApplyColors(activeBtn, true);
        }

        private void ShowDashboard()
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm = null;
            }

            panelContent.Controls.Clear();

            if (dashboardContent != null)
            {
                dashboardContent.Dock = DockStyle.Fill;
                panelContent.Controls.Add(dashboardContent);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm = null;
            }

            activeChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        // ====== CLICK EVENT’LERİ ======

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            ShowDashboard();
            SetActiveMenu(btnMainMenu);
            panelContent.Select(); // ✅ tıklayınca da focus içerikte kalsın
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CarsForm());
            SetActiveMenu(btnCars);
            panelContent.Select();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomersForm());
            SetActiveMenu(btnCustomers);
            panelContent.Select();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RentalsForm());
            SetActiveMenu(btnRent);
            panelContent.Select();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm());
            SetActiveMenu(btnReports);
            panelContent.Select();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartsForm());
            SetActiveMenu(btnCharts);
            panelContent.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?",
                "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // boşlar kalsın
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
    }
}
