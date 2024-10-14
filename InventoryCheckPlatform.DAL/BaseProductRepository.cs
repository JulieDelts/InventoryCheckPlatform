using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class BaseProductRepository
    {
        private InventoryCheckContext _context;

        public BaseProductRepository() 
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddBaseProduct(BaseProduct baseProduct)
        {
            _context.BaseProduct.Add(baseProduct);
            await _context.SaveChangesAsync();

            return baseProduct.Id;
        }

        public async Task<BaseProduct> GetBaseProductById(int id)
        {
            var baseProduct = await _context.BaseProduct.Where(s => s.Id == id).FirstOrDefaultAsync();

            if (baseProduct != null)
            {
                return baseProduct;
            }
            else
            {
                throw new Exception("The product is not found.");
            }
        }

        public async Task<List<BaseProduct>> GetAllBaseProducts()
        {
            var baseProducts = await _context.BaseProduct.ToListAsync();

            if (baseProducts != null)
            {
                return baseProducts;
            }
            else
            {
                return new List<BaseProduct>();
            }
        }

        public async Task<int> UpdateBaseProduct(BaseProduct baseProduct)
        {
            var baseProductToUpdate = await GetBaseProductById(baseProduct.Id);

            baseProductToUpdate.Name = baseProduct.Name;
            baseProductToUpdate.FileName = baseProduct.FileName;
            baseProductToUpdate.Category = baseProduct.Category;

            await _context.SaveChangesAsync();

            return baseProductToUpdate.Id;
        }

        public async Task<int> DeleteBaseProduct(int id)
        {
            var baseProductToDelete = await GetBaseProductById(id);

            _context.BaseProduct.Remove(baseProductToDelete);
            await _context.SaveChangesAsync();

            return baseProductToDelete.Id;
        }
    }
}
