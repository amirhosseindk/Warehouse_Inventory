Warehouse Management Project
This project is a warehouse management system that allows you to manage information about products, categories, suppliers, countries of origin, units of measurement, consumers, warehouses, and inventory turnovers.

Installation and Setup
Clone the project or download it as a ZIP file.
Make sure you have the .NET SDK installed.
Open the project folder in the command line or terminal.
Run the dotnet restore command to install the required packages.
Build the project using the dotnet build command.
Run the project using the dotnet run command.
Using the Project
This project is designed based on the Single Responsibility pattern and entities. To use this project, you can create instances of the available classes and perform the desired operations.

Classes and Entities
The project includes the following classes:

Product: Product class
Category: Product category class
Supplier: Supplier class
MadeInCountry: Country of origin class
UnitMeasure: Unit of measurement class
Consumer: Consumer class
Inventory: Inventory class
Warehouse: Warehouse class
InventoryRequisition: Inventory requisition class
InventoryReceipt: Inventory receipt class
InsideTransfer: Inside transfer class
InventoryTurnover: Inventory turnover class
DbContext Configuration
The WarehouseManagementDbContext class is responsible for setting up the connection to the SQL Server database and configuring the relationships between the entities.

To connect to SQL Server, add the following code in the OnConfiguring method:

optionsBuilder.UseSqlServer(YOUR_CONNECTION_STRING);

To prevent cascade cycles, add the following code in the OnModelCreating method:

foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
{
    relationship.DeleteBehavior = DeleteBehavior.Restrict;
}

Contributing
Feel free to fork this project and submit your contributions through pull requests. Please ensure that your code follows the existing patterns and conventions.
