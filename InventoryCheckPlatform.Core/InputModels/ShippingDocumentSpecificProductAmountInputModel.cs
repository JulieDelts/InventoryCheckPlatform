
namespace InventoryCheckPlatform.Core.InputModels
{
    public class ShippingDocumentSpecificProductAmountInputModel
    {
        public int SpecificProductId { get; set; }

        public int ShippingDocumentId { get; set; }

        public int ProductAmount { get; set; }
    }
}
