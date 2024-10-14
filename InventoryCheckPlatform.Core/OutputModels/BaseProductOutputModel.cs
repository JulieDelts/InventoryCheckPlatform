
namespace InventoryCheckPlatform.Core.OutputModels
{
	public class BaseProductOutputModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Category { get; set; }

        public string? FileName { get; set; }
    }
}
