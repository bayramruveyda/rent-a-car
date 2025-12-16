using System;
using System.Windows.Forms;

namespace CarRentalLogin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanını hazırla
            DbHelper.InitializeDatabase();

            // İlk açılacak form
            Application.Run(new Form1());
        }
    }
}

