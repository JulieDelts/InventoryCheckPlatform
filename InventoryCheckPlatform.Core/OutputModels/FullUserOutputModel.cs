using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.Core.OutputModels
{
    public class FullUserOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public int RestaurantId { get; set; }

    }
}
