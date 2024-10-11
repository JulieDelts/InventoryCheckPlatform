
namespace InventoryCheckPlatform.Core.DTOs
{
    public class ReceiptRecipeAmount
    {
        public int Id { get; set; }

        public Recipe Recipe { get; set; }

        public Receipt Receipt { get; set; }

        public int Amount { get; set; }
    }
}
