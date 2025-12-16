using System;
using System.Data.SQLite;
using System.IO;

namespace CarRentalLogin
{
    internal static class DbHelper
    {
        private static readonly string dbFile = "car_rental.db";
        private static readonly string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // ==================== INIT ====================
        public static void Initialize()
        {
            // DB yoksa oluştur
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var conn = GetConnection())
            {
                conn.Open();

                // ===================== CARS =====================
                string carsSql = @"
                CREATE TABLE IF NOT EXISTS Cars (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    Brand       TEXT    NOT NULL,
                    Model       TEXT    NOT NULL,
                    Plate       TEXT    NOT NULL UNIQUE,
                    Year        INTEGER,
                    DailyPrice  REAL,
                    IsAvailable INTEGER NOT NULL
                );";

                new SQLiteCommand(carsSql, conn).ExecuteNonQuery();

                // =================== CUSTOMERS ==================
                string customersSql = @"
                CREATE TABLE IF NOT EXISTS Customers (
                    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName   TEXT    NOT NULL,
                    Phone      TEXT,
                    Email      TEXT,
                    TcNo       TEXT,
                    LicenseNo  TEXT,
                    IsActive   INTEGER NOT NULL DEFAULT 1
                );";

                new SQLiteCommand(customersSql, conn).ExecuteNonQuery();

                // ==================== RENTALS ===================
                string rentalsSql = @"
                CREATE TABLE IF NOT EXISTS Rentals (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    CarId       INTEGER NOT NULL,
                    CustomerId  INTEGER NOT NULL,
                    StartDate   TEXT    NOT NULL,
                    EndDate     TEXT    NOT NULL,
                    DailyPrice  REAL    NOT NULL,
                    TotalPrice  REAL    NOT NULL,
                    Status      TEXT    NOT NULL,
                    FOREIGN KEY (CarId)      REFERENCES Cars(Id),
                    FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
                );";

                new SQLiteCommand(rentalsSql, conn).ExecuteNonQuery();
            }
        }

        // ==================== ID'Yİ 1'DEN BAŞLAT ====================
        public static void ResetCustomersIdentity()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                // Customers tablosunu temizle
                new SQLiteCommand("DELETE FROM Customers;", conn).ExecuteNonQuery();

                // AUTOINCREMENT sayacını sıfırla
                new SQLiteCommand(
                    "DELETE FROM sqlite_sequence WHERE name='Customers';",
                    conn
                ).ExecuteNonQuery();
            }
        }

        // ==================== DB PATH KONTROL ====================
        public static string GetDbPath()
        {
            return Path.GetFullPath(dbFile);
        }

        // eski çağrılar bozulmasın diye
        public static void InitializeDatabase()
        {
            Initialize();
        }
    }
}
