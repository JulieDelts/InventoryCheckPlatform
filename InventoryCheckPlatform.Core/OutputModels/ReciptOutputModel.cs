using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class ReciptOutputModel
    {
        public int Id { get; set; } 
        public DateTime IssueTime { get; set; }

        public User Waiter { get; set; }

        public double TotalSum { get; set; }

        public List<RecipeInputModel>? RecipeInputModel { get; set; }
    }
}
