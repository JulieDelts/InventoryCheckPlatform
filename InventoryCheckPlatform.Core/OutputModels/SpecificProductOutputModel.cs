
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class SpecificProductOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BaseProductId { get; set; }

        public string Category { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }
    }
}
