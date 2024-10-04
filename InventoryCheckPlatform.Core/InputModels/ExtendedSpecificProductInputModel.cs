
namespace InventoryCheckPlatform.Core.InputModels
{
    public class ExtendedSpecificProductInputModel: ExtendedBaseProductInputModel
    {
        public string Vendor { get; set; }

        public double Price { get; set; }
    }
}
