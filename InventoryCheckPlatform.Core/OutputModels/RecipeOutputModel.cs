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
        public string Title { get; set; }
        public List<BaseProductOutputModel> Ingredients { get; set; } = new List<BaseProductOutputModel>();  

    }
}
