using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class LogisticianSpecificProductRepository
    {
        private InventoryCheckContext _context;

        public LogisticianSpecificProductRepository()
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddSpecificProduct(SpecificProduct specificProduct)
        {
            _context.SpecificProduct.Add(specificProduct);
            await _context.SaveChangesAsync();

            return specificProduct.Id;
        }

        public async Task<SpecificProduct> GetSpecificProductById(int id)
        {
            var specificProduct = await _context.SpecificProduct.Where(s => s.Id == id).FirstOrDefaultAsync();

            if (specificProduct != null)
            {
                return specificProduct;
            }
            else
            {
                throw new Exception("The product is not found.");
            }
        }

        public async Task<List<SpecificProduct>> GetAllSpecificProducts()
        {
            var specififcProducts = await _context.SpecificProduct.ToListAsync();

            if (specififcProducts != null)
            {
                return specififcProducts;
            }
            else
            {
                return new List<SpecificProduct>();
            }
        }

        public async Task<int> UpdateSpecificProduct(SpecificProduct specificProduct)
        {
            var specificProductToUpdate = await GetSpecificProductById(specificProduct.Id);

            specificProductToUpdate.Vendor = specificProduct.Vendor;
            specificProductToUpdate.Price = specificProduct.Price;
            specificProductToUpdate.FileName = specificProduct.FileName;

            await _context.SaveChangesAsync();

            return specificProductToUpdate.Id;
        }

        public async Task<int> DeleteSpecificProduct(int id)
        {
            var specificProductToDelete = await GetSpecificProductById(id);

            _context.SpecificProduct.Remove(specificProductToDelete);
            await _context.SaveChangesAsync();

            return specificProductToDelete.Id;
        }
    }
}
