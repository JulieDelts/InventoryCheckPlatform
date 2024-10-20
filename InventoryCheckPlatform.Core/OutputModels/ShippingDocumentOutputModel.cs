
using InventoryCheckPlatform.Core.DTOs;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class ShippingDocumentOutputModel
    {
        public int Id { get; set; }

        public ShortUserOutputModel Logistician { get; set; }

        public RestaurantOutputModel Restaurant { get; set; }

		public string Status { get; set; }

        public DateOnly IssueDate { get; set; }

        public DateOnly? DeliveryDate { get; set; }

        public double? FullPrice { get; set; }

        public List<ShippingDocumentSpecificProductAmount>? ShippingDocumentSpecificProductAmounts { get; set; }
    }
}
