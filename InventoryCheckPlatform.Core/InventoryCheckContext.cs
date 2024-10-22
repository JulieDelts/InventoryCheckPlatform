using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

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
            string connectionString = Options.ConnectionString;
            optionsBuilder.UseNpgsql(connectionString);
        }
        private void Log(string logMessage)
        {
            // ���������� ���� � ����������� �� ���� ���������
            var color = GetLogColor(logMessage);
            Console.ForegroundColor = color;
            Console.WriteLine(logMessage);
            Console.ResetColor();
        }

        private ConsoleColor GetLogColor(string message)
        {
            // ������: �� ������ ���������� ������ ��� ������ ����� �� ������ ���������� ���������
            if (message.Contains("Error"))
                return ConsoleColor.Red;
            else if (message.Contains("warn"))
                return ConsoleColor.Yellow;
            else if (message.Contains("info"))
                return ConsoleColor.Green;
            else
                return ConsoleColor.White; // ��� ��������� ���������
        }
    }
}