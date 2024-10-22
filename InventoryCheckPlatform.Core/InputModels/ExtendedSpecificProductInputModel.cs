
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class ExtendedSpecificProductInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название.")]
        public string Name { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Значение должно быть больше 0."), Required(ErrorMessage = "Необходимо ввести идентификатор продукта.")]
		public int BaseProductId { get; set; }

        [CustomFileExtensionValidation]
        public string? FileName { get; set; }

		[Required(ErrorMessage = "Необходимо ввести поставщика.")]
		public string Vendor { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Значение должно быть больше 0."), Required(ErrorMessage = "Необходимо ввести цену.")]
		public double Price { get; set; }
    }
}
