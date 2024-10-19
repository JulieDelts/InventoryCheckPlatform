using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class RecipeInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [CustomFileExtensionValidation]
        public string FileName { get; set; }
        public List<BaseProductForRecipeInputModel> Ingredients { get; set; } = new List<BaseProductForRecipeInputModel>();
    }
}
