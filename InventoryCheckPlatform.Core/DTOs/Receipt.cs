
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryCheckPlatform.Core.DTOs
{
	public class Receipt
    {
		public int Id { get; set; }

		public DateTime IssueTime { get; set; }
        [ForeignKey("WaiterId")]
        public User Waiter { get; set; }
        public int WaiterId { get; set; }

        public double FullPrice { get; set; }

        public List<ReceiptRecipeAmount>? ReceiptRecipeAmounts { get; set; }
    }
}
