
namespace InventoryCheckPlatform.Core.InputModels
{
	public class ExtendedShippingDocumentInputModel
	{
		public int Id { get; set; }	

		public int LogisticianId { get; set; }

		public int RestaurantId { get; set; }

		public string Status { get; set; }

		public DateOnly IssueDate { get; set; }

		public DateOnly? DeliveryDate { get; set; }
	}
}
