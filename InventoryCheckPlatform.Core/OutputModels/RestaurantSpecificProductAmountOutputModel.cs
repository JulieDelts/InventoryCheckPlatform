
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class RestaurantSpecificProductAmountOutputModel
    {
        public SpecificProductOutputModel SpecificProduct { get; set; }

        public RestaurantOutputModel Restaurant { get; set; }

        public int ProductAmount { get; set; }
    }
}
