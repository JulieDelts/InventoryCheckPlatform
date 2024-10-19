using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.Core
{
    public class InventoryCheckContext: DbContext
    {
        public DbSet<BaseProduct> BaseProduct { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Receipt> Receipt { get; set; }

        public DbSet<Recipe> Recipe { get; set; }

        public DbSet<Restaurant> Restaurant { get; set; }

        public DbSet<ShippingDocument> ShippingDocument { get; set; }

        public DbSet<SpecificProduct> SpecificProduct { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<ReceiptRecipeAmount> ReceiptRecipeAmount { get; set; }

        public DbSet<RecipeBaseProductAmount> RecipeBaseProductAmount { get; set; }

        public DbSet<RestaurantSpecificProductAmount> RestaurantSpecificProductAmount { get; set; }

        public DbSet<ShippingDocumentSpecificProductAmount> ShippingDocumentSpecificProductAmount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Port=5432;Database=invcheckdb;Username=postgres;Password=1234;";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<User>().HasOne(u => u.Restaurant).WithOne(r => r.Admin).HasForeignKey<Restaurant>(r => r.AdminId);
        }

    }
}