using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class ShortUserOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserRole { get; set; }
        public int RestaurantId { get; set; }

    }
}
