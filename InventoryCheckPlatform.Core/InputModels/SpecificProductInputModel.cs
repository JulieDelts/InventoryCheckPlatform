
namespace InventoryCheckPlatform.Core.InputModels
{
    public class SpecificProductInputModel: BaseProductInputModel
    {
        public string Vendor { get; set; }

        public double Price { get; set; }
    }
}
