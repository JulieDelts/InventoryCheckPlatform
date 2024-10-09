
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
	public class RestaurantInputModel
	{
        [Required(ErrorMessage = "Необходимо ввести адрес.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Необходимо ввести идентификатор администратора.")]
        public int AdminId { get; set; }

        [CustomFileExtensionValidation]
        public string? FileName { get; set; }
    }
}
