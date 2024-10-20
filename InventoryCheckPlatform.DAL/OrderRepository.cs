using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.DAL
{
    public class OrderRepository
    {
        private InventoryCheckContext _context;
        public OrderRepository()
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return order.Id;
        }

        public async Task<Order> GetOrderById(int id)
        {
            var order = await _context.Orders.Where(s => s.Id == id).Include(r => r.Recipes).FirstOrDefaultAsync();

            if (order != null)
            {
                return order;
            }
            else
            {
                throw new Exception("The restaurant is not found.");
            }
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var orders = await _context.Orders.Include(r => r.Recipes).ToListAsync();

            if (orders != null)
            {
                return orders;
            }
            else
            {
                return new List<Order>();
            }
        }

        public async Task<int> UpdateOrder(Order order)
        {
            var orerToUpdate = await GetOrderById(order.Id);

            order.Recipes.CopyTo(orerToUpdate.Recipes.ToArray());
            orerToUpdate.Status = order.Status;
            orerToUpdate.DateTime= order.DateTime;
            orerToUpdate.TotalSum = order.TotalSum;
            

            await _context.SaveChangesAsync();

            return orerToUpdate.Id;
        }

        public async Task<int> DeleteRestaurant(int id)
        {
            var orderToDelete = await GetOrderById(id);

            _context.Orders.Remove(orderToDelete);
            await _context.SaveChangesAsync();

            return orderToDelete.Id;
        }





    }
}
