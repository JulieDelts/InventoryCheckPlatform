
namespace InventoryCheckPlatform.Core.InputModels
{
    public class ShippingDocumentInputModel
    {
        public int LogisticianId { get; set; }

        public int RestaurantId { get; set; }

		public string Status { get; set; }

        public DateOnly IssueDate { get; set; }
    }
}
