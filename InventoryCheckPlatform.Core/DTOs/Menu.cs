
namespace InventoryCheckPlatform.Core.DTOs
{
	public class Menu
	{
		public int Id { get; set; }

		public bool IsActive { get; set; }

		public Restaurant Restaurant { get; set; }

		public string? Type { get; set; }

		public List<Recipe>? Recipes { get; set; }
	}
}
