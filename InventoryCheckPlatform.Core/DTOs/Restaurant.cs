
namespace InventoryCheckPlatform.Core.DTOs
{
	public class Restaurant
	{
		public int Id { get; set; }

		public string Address { get; set; }

		public List<User>? Users { get; set; }

		public List<Menu>? Menus { get; set; }

		public string? FileName { get; set; }

		public List<RestaurantSpecificProductAmount>? RestaurantSpecificProductAmounts { get; set; }
	}
}
