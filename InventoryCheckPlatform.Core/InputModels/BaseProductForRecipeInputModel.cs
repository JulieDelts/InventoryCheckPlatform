using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class BaseProductForRecipeInputModel
    {
        [Required(ErrorMessage = "Необходимо ввести название.")]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Count { get; set; }  

    }
}
