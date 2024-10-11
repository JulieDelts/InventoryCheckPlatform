
namespace InventoryCheckPlatform.Core.DTOs
{
	public class Recipe
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Restaurant Restaurant { get; set; }

		List<Menu>? Menus { get; set; }

		public double Price { get; set; }

        public string? FileName { get; set; }

        public List<RecipeBaseProductAmount>? RecipeBaseProductAmounts { get; set; }

		public List<ReceiptRecipeAmount>? ReceiptRecipeAmounts { get; set; }
    }
}
