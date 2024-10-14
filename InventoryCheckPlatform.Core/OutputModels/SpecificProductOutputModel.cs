
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class SpecificProductOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BaseProductOutputModel BaseProduct { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }

        public string? FileName { get; set; }
    }
}
