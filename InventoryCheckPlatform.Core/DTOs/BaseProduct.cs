
namespace InventoryCheckPlatform.Core.DTOs
{
	public class BaseProduct
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string? Category { get; set; }

		public string? FileName { get; set; }

		public List<SpecificProduct>? SpecificProduct { get; set; }

		public List<RecipeBaseProductAmount>? RecipeBaseProductAmounts { get; set; }
	}
}
