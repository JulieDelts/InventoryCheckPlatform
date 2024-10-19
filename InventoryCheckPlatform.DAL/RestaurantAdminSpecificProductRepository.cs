using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class RestaurantAdminSpecificProductRepository
    {
        private InventoryCheckContext _context;

        public RestaurantAdminSpecificProductRepository()
        {
            _context = new InventoryCheckContext();
        }

        public async Task<List<RestaurantSpecificProductAmount>> GetAllSpecificProductsByRestaurantId(int id)
        {
            var restaurant = await _context.Restaurant.Where(r => r.Id == id).Include(r => r.RestaurantSpecificProductAmounts).ThenInclude(p => p.SpecificProduct).FirstOrDefaultAsync();

            if (restaurant != null)
            {
                var products = restaurant.RestaurantSpecificProductAmounts;

                if (products != null)
                {
                    return products;
                }
                else
                {
                    return new List<RestaurantSpecificProductAmount>();
                }
            }
            else 
            {
                throw new Exception("The restaurant is not found.");
            }
        }

        public async Task<RestaurantSpecificProductAmount> GetSpecificProductWithAmountById(int restaurantId, int productId)
        {
            var specificProductAmount = await _context.RestaurantSpecificProductAmount.Where(r => r.Restaurant.Id == restaurantId &&  r.SpecificProduct.Id == productId).Include(p => p.SpecificProduct).FirstOrDefaultAsync();

            if (specificProductAmount != null)
            {
                return specificProductAmount;
            }
            else
            {
                throw new Exception("The product is not found.");
            }
        }

        public async Task AddSpecificProductsToRestaurant(List<RestaurantSpecificProductAmount> productAmounts)
        {
            if (productAmounts.Count > 0)
            {
                for (int i = 0; i < productAmounts.Count; i++)
                {
                    var specificProduct = await _context.SpecificProduct.Where(pa => pa.Id == productAmounts[i].SpecificProduct.Id).FirstOrDefaultAsync();
                    var restaurant = await _context.Restaurant.Where(r => r.Id == productAmounts[i].Restaurant.Id).FirstOrDefaultAsync();

                    if (specificProduct != null && restaurant != null)
                    {
                        productAmounts[i].SpecificProduct = specificProduct;
                        productAmounts[i].Restaurant = restaurant;
                    }
                    else
                    {
                        throw new Exception("The entities are not found.");
                    }
                }
            }
            _context.RestaurantSpecificProductAmount.AddRange(productAmounts);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSpecificProductAmount(RestaurantSpecificProductAmount productAmount)
        {
            var specificProductAmountToUpdate = await GetSpecificProductWithAmountById(productAmount.Restaurant.Id, productAmount.SpecificProduct.Id);

            specificProductAmountToUpdate.ProductAmount = productAmount.ProductAmount;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSpecificProduct(RestaurantSpecificProductAmount productAmount)
        {
            var specificProductAmountToDelete = await GetSpecificProductWithAmountById(productAmount.Restaurant.Id, productAmount.SpecificProduct.Id);

            _context.RestaurantSpecificProductAmount.Remove(specificProductAmountToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
