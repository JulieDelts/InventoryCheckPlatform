
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class SpecificProductInputModel
    {
        [Required(ErrorMessage = "Необходимо ввести название.")]
        public string Name { get; set; }

        public int BaseProductId { get; set; }

        [CustomFileExtensionValidation]
        public string? FileName { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }
    }
}
