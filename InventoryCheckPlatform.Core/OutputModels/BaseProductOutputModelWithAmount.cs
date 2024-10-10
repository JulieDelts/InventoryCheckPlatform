
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class BaseProductOutputModelWithAmount
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public int Amount { get; set; }
    }
}
