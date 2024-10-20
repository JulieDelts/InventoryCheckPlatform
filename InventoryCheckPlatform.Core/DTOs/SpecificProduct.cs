
namespace InventoryCheckPlatform.Core.DTOs
{
	public class SpecificProduct
	{
		public int Id { get; set; }

        public string Name { get; set; }

		public string Vendor { get; set; }

		public double Price { get; set; }

        public string? FileName { get; set; }

        public BaseProduct BaseProduct { get; set; }

        public List<RestaurantSpecificProductAmount>? RestaurantSpecificProductAmounts { get; set; }

        public List<ShippingDocumentSpecificProductAmount>? ShippingDocumentSpecificProductAmounts { get; set; }
    }
}
