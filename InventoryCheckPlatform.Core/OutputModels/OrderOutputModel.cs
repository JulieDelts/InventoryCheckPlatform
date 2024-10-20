using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class OrderOutputModel
    {
        public int Id { get; set; }
        public List<DishOutputModel> Dishes { get; set; } = new();
        public decimal TotalAmount => Dishes.Sum(dish => dish.Price);
    }
}
