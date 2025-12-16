using System;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace CarRentalLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // başlangıç: şifre gizli
            checkBox1.Checked = false;
            textBox2.PasswordChar = '●';
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            // 1) maske ayarları
            if (e.Checked)
            {
                // GÖSTER
                textBox2.UseSystemPasswordChar = false;
                textBox2.PasswordChar = '\0';
            }
            else
            {
                // GİZLE
                textBox2.PasswordChar = '●';
                textBox2.UseSystemPasswordChar = true;
            }

            // 2) Bunifu bazen UI'ı yenilemiyor -> metni resetleyerek zorla uygulat
            string t = textBox2.Text;
            textBox2.Text = "";
            textBox2.Text = t;
            textBox2.SelectionStart = textBox2.TextLength;

            // 3) repaint
            textBox2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}
