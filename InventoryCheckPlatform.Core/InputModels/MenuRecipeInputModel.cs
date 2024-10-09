using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class MenuRecipeInputModel
    {
        public string Title { get; set; }
        public string Instructions { get; set; }
        public List<BaseProductInputModel> Ingredients { get; set; } = new List<BaseProductInputModel>();
    }
}
