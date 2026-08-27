🚗 Rent A Car

A Windows desktop car rental management application built with C# WinForms, .NET Framework 4.7.2, and SQLite.

The application manages vehicles, customers, rentals, reports, and charts from a desktop interface.

✨ Features

Vehicle management

Customer management

Rental creation and tracking

Automatic rental total calculation

Vehicle availability tracking

Automatic completion of expired rentals

Reports and charts

Local SQLite database initialization

🧱 Project Structure

The main WinForms project is located in:

CarRentalLogin/

Important application screens include:

CarsForm
CustomersForm
RentalsForm
ReportsForm
ChartsForm
MainForm

Database initialization and connection logic is handled by:

CarRentalLogin/DbHelper.cs

🗄️ Database

The project uses a local SQLite database named:

car_rental.db

The application creates these main tables when needed:

Cars

Customers

Rentals

Rental records are connected to vehicles and customers through foreign keys.

🛠️ Technologies

C#

Windows Forms

.NET Framework 4.7.2

SQLite

System.Data.SQLite

Bunifu UI WinForms

Windows Forms Data Visualization

▶️ Run Locally

Clone the repository.

Open CarRentalLogin.sln in Visual Studio.

Restore NuGet packages.

Build the solution.

Run the CarRentalLogin project.

The SQLite database is initialized by the application if it does not already exist.

📌 Notes

This project was developed as a desktop software project for practicing database-backed application development, CRUD workflows, rental logic, and desktop UI design.

👩‍💻 Author

Rüveyda Bayram

GitHub: @bayramruveyda
