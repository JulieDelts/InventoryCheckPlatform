
using System.ComponentModel.DataAnnotations;

namespace InventoryCheckPlatform.Core
{
    public class CustomFileExtensionValidationAttribute: ValidationAttribute
    {
        List<string> _validFileExtensions = new() { "jpg", "jpeg", "bmp", "png" };

        public CustomFileExtensionValidationAttribute()
        {
            ErrorMessage = "Я картинки хочу, кретин!";
        }
        public override bool IsValid(object? fileName)
        {
            if (fileName == null || fileName.ToString() == "") return true;

            var file = (string)fileName;

            if (string.IsNullOrEmpty(file)) return false;

            var extension = file.Split(".").Last().ToLower();

            return _validFileExtensions.Contains(extension);
        }
    }
}
