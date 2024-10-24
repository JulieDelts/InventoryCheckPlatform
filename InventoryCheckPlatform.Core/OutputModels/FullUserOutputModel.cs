﻿
namespace InventoryCheckPlatform.Core.OutputModels
{
    public class FullUserOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public int? RestaurantId { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? FileName { get; set; }
    }
}
