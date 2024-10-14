
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class RestaurantSpecificProductAmountOutputModel
    {
        public int SpecificProductId { get; set; }

        public int RestaurantId { get; set; }

        public int ProductAmount { get; set; }
    }
}
