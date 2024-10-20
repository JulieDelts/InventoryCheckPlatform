
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class ShippingDocumentSpecificProductAmountOutputModel
    {
        public ShippingDocumentOutputModel ShippingDocument { get; set; }

        public SpecificProductOutputModel SpecificProduct { get; set; }

        public int ProductAmount { get; set; }
    }
}
