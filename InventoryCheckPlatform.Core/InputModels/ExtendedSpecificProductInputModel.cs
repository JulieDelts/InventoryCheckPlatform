
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class ExtendedSpecificProductInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название.")]
        public string Name { get; set; }

        public int BaseProductId { get; set; }

        public string Category { get; set; } = string.Empty;

        [CustomFileExtensionValidation]
        public string FileName { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }
    }
}
