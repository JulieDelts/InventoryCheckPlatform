using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class ReceiptRepository
    {
        private InventoryCheckContext _context;
        public ReceiptRepository()
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddOrder(Receipt receipt)
        {
            _context.Receipt.Add(receipt);
            await _context.SaveChangesAsync();

            return receipt.Id;
        }

        public async Task<Receipt> GetOrderById(int id)
        {
            var receipt = await _context.Receipt.Where(s => s.Id == id).Include(r => r.ReceiptRecipeAmounts).FirstOrDefaultAsync();

            if (receipt != null)
            {
                return receipt;
            }
            else
            {
                throw new Exception("The restaurant is not found.");
            }
        }

        public async Task<List<Receipt>> GetAllRecriptAsync()
        {
            try
            {
                var receipts = _context.Database.ExecuteSqlRaw("SELECT * FROM public.\"Receipt\"");

                var x = await _context.Receipt.FirstOrDefaultAsync();
                return await _context.Receipt.Include(r => r.ReceiptRecipeAmounts).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении чеков: " + ex.Message);
                return new List<Receipt>(); 
            }
        }

        public async Task<int> UpdateOrder(Receipt receipt)
        {
            var receiptToUpdate = await GetOrderById(receipt.Id);

            receiptToUpdate.ReceiptRecipeAmounts.CopyTo(receiptToUpdate.ReceiptRecipeAmounts.ToArray());
            receiptToUpdate.Waiter = receipt.Waiter;
            receiptToUpdate.IssueTime= receipt.IssueTime;
            receiptToUpdate.FullPrice = receipt.FullPrice;
            

            await _context.SaveChangesAsync();

            return receiptToUpdate.Id;
        }

        public async Task<int> DeleteReceipte(int id)
        {
            var orderToDelete = await GetOrderById(id);

            _context.Receipt.Remove(orderToDelete);
            await _context.SaveChangesAsync();

            return orderToDelete.Id;
        }


    }
}
