using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        // Your DbSet properties for each entity
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<MadeInCountry> MadeInCountries { get; set; }
        public DbSet<UnitMeasure> UnitMeasures { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<InventoryRequisition> InventoryRequisitions { get; set; }
        public DbSet<InventoryReceipt> InventoryReceipts { get; set; }
        public DbSet<InsideTransfer> InsideTransfers { get; set; }
        public DbSet<InventoryTurnover> InventoryTurnovers { get; set; }
        public DbSet<InventoryItemList> InventoryItemLists { get; set; }
        public DbSet<BuyRequest> BuyRequests { get; set; }
        public DbSet<BuyRequestItemList> buyRequestItemLists { get; set; }
        public DbSet<ConsumerInvoice> ConsumerInvoices { get; set; }
        public DbSet<InsideTransferItemList> insideTransferItemLists { get; set; }
        public DbSet<ReceiptItemList> ReceiptItemList { get; set; }
        public DbSet<RequisitionItemList> RequisitionItemList { get; set; }
        public DbSet<SupplierInvoice> supplierInvoices { get; set; }
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Warehouse_Inventory;User Id=sa;Password=P@ssw0rd09198799866;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Any additional modelBuilder configurations
            //Add-Migration InitialCreate -Project Persistence -StartupProject Persistence 
        }
    }
}
