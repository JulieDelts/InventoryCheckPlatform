
namespace InventoryCheckPlatform.Core.DTOs
{
    public class ShippingDocumentSpecificProductAmount
    {
        public int Id { get; set; }

        public SpecificProduct SpecificProduct { get; set; }

        public ShippingDocument ShippingDocument { get; set; }

        public int ProductAmount { get; set; }
    }
}
