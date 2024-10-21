

using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class RestaurantSpecificProductAmountInputModel
    {
        public int SpecificProductId { get; set; }

        public int RestaurantId { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Значение должно быть больше 0."), Required(ErrorMessage = "Необходимо ввести количество продукта.")]
		public int ProductAmount { get; set; }
    }
}
