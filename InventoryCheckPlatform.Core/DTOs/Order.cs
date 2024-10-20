using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.DTOs
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal TotalSum { get; set; }
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
        public bool Status { get; set; }
    }
}
