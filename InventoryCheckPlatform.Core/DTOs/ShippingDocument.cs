
namespace InventoryCheckPlatform.Core.DTOs
{
	public class ShippingDocument
	{
		public int Id { get; set; }

		public User Logistician { get; set; }

		public Restaurant Restaurant { get; set; }

		public List<SpecificProduct> Products { get; set; }

		public double FullPrice { get; set; }
	}
}
