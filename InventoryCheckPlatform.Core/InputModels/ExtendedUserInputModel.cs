
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class ExtendedUserInputModel
    {
        public int Id { get; set; }

		[Required(ErrorMessage = "Необходимо ввести имя пользователя.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Необходимо ввести логин пользователя.")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Необходимо ввести пароль пользователя.")]
		public string Password { get; set; }

        [RoleValidation]
        public string Role { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Значение должно быть больше 0.")]
		public int? RestaurantId { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        [CustomFileExtensionValidation]
        public string? FileName { get; set; }
    }
}
