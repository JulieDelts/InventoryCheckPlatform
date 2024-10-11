
namespace InventoryCheckPlatform.Core.DTOs
{
    public class RecipeBaseProductAmount
    {
        public int Id { get; set; }

        public BaseProduct BaseProduct { get; set; }

        public Recipe Recipe { get; set; }

        public int ProductAmount { get; set; }
    }
}
