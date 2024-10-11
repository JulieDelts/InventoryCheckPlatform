
namespace InventoryCheckPlatform.Core.DTOs
{
	public class Restaurant
	{
		public int Id { get; set; }

		public string Address { get; set; }

		public int AdminId { get; set; }

		public User Admin { get; set; }

		public List<User>? Waiters { get; set; }

		public List<Menu>? Menus { get; set; }

		public string? FileName { get; set; }

		public List<RestaurantSpecificProductAmount>? RestaurantSpecificProductAmounts { get; set; }
	}
}
