using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class RestaurantRepository
    {
        private InventoryCheckContext _context;
        public RestaurantRepository() 
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddRestaurant(Restaurant restaurant)
        {
            _context.Restaurant.Add(restaurant);
            await _context.SaveChangesAsync();

            return restaurant.Id;
        }

        public async Task<Restaurant> GetRestaurantById(int id)
        {
            var restaurant = await _context.Restaurant.Where(s => s.Id == id).Include(r => r.RestaurantSpecificProductAmounts).ThenInclude(p => p.SpecificProduct).Include(r => r.Admin).FirstOrDefaultAsync();

            if (restaurant != null)
            {
                return restaurant;
            }
            else
            {
                throw new Exception("The restaurant is not found.");
            }
        }

        public async Task<List<Restaurant>> GetAllRestaurants()
        {
            var restaurants = await _context.Restaurant.Include(r => r.Admin).ToListAsync();

            return restaurants;
        }

        public async Task<int> UpdateRestaurant(Restaurant restaurant)
        {
            var restaurantToUpdate = await GetRestaurantById(restaurant.Id);

            restaurantToUpdate.Address = restaurant.Address;
            restaurantToUpdate.FileName = restaurant.FileName;
            restaurantToUpdate.AdminId = restaurant.AdminId;

             await _context.SaveChangesAsync();

            return restaurantToUpdate.Id;
        }

        public async Task<int> DeleteRestaurant(int id)
        {
            var restaurantToDelete = await GetRestaurantById(id);

            _context.Restaurant.Remove(restaurantToDelete);
            await _context.SaveChangesAsync();

            return restaurantToDelete.Id;
        }
    }
}
