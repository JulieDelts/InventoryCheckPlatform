using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class ExtendedBaseProductInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название.")]

        public string Name { get; set; }

        public string? Category { get; set; } = string.Empty;
    }
}
