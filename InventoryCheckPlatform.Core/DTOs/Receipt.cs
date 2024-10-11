
namespace InventoryCheckPlatform.Core.DTOs
{
	public class Receipt
	{
		public int Id { get; set; }

		public DateTime IssueTime { get; set; }

		public User Waiter { get; set; }

		public double FullPrice { get; set; }

        public List<ReceiptRecipeAmount>? ReceiptRecipeAmounts { get; set; }
    }
}
