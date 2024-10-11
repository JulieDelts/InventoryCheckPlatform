
namespace InventoryCheckPlatform.Core.DTOs
{
    public class RestaurantSpecificProductAmount
    {
        public int Id { get; set; }

        public SpecificProduct SpecificProduct { get; set; }

        public Restaurant Restaurant { get; set; }

        public int ProductAmount { get; set; }
    }
}
