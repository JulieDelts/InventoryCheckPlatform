
namespace InventoryCheckPlatform.Core.DTOs
{
	public class ShippingDocument
	{
		public int Id { get; set; }

		public User Logistician { get; set; }

		public Restaurant Restaurant { get; set; }

		public string Status { get; set; }

		public DateOnly IssueDate { get; set; }

		public DateOnly? DeliveryDate { get; set; }

		public double? FullPrice { get; set; }

		public List<ShippingDocumentSpecificProductAmount>? ShippingDocumentSpecificProductAmounts { get; set; }
	}
}
