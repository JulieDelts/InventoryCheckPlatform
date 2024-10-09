
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class SpecificProductInputModel: BaseProductInputModel
    {
        [Required(ErrorMessage = "Необходимо ввести название.")]
        public string Name { get; set; }

        public string Category { get; set; } = string.Empty;

        [CustomFileExtensionValidation]
        public string FileName { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }
    }
}
