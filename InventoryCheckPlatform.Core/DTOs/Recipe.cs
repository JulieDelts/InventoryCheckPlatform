
namespace InventoryCheckPlatform.Core.DTOs
{
	public class Recipe
	{
		public int Id { get; set; }

		public string Name { get; set; }

		List<Menu>? Menus { get; set; }

		List<BaseProduct> BaseProducts { get; set; }

		public double Price { get; set; }

        public string? FileName { get; set; }
    }
}
