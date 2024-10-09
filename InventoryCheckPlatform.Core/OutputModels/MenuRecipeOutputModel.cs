using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class MenuRecipeOutputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }
        public List<BasePoductOutputModel> Ingredients { get; set; } = new List<BasePoductOutputModel>();  

    }
}
