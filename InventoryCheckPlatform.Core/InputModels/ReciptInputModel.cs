using InventoryCheckPlatform.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.InputModels
{
    public class ReciptInputModel
    {
        public DateTime IssueTime { get; set; }

        public User Waiter { get; set; }

        public double TotalSum { get; set; }

        public List<RecipeInputModel>? RecipeInputModel { get; set; }

    }
}
