
using InventoryCheckPlatform.Core.DTOs;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class RestaurantSpecificProductAmountInputModel
    {
        public int SpecificProductId { get; set; }

        public int RestaurantId { get; set; }

        public int ProductAmount { get; set; }
    }
}
