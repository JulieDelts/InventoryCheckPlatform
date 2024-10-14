
using InventoryCheckPlatform.Core.DTOs;

namespace InventoryCheckPlatform.Core.OutputModels
{
	public class RestaurantOutputModel
	{
		public int Id { get; set; }

		public string Address { get; set; }

        public string? FileName { get; set; }

        public ShortUserOutputModel Admin { get; set; }
	}
}
