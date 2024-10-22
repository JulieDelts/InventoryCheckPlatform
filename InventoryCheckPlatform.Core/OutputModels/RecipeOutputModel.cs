using InventoryCheckPlatform.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class RecipeOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public List<BaseProductForRecipeInputModel> RecipeBaseProductAmount { get; set; } = new List<BaseProductForRecipeInputModel>();  

    }
}
