using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
	public class BaseProductInputModel
	{
        [Required(ErrorMessage = "Необходимо ввести название.")]
        public string Name { get; set; }

		public string Category { get; set; } = string.Empty;

        [CustomFileExtensionValidation]
        public string? FileName { get; set; }

    }
}
