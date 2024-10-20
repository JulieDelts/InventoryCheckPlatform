
using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class UserRepository
    {
        private InventoryCheckContext _context;


        public UserRepository()
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddUser(User user)
        {
            if(user.Restaurant!= null) 
            {
                var restaurant = await _context.Restaurant.Where(u => u.Id == user.Restaurant.Id).FirstOrDefaultAsync();

                user.Restaurant = restaurant;
            }
           
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _context.User.Where(s => s.Id == id).Include(u => u.Restaurant).FirstOrDefaultAsync();

            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("The user is not found.");
            }
        }

        public async Task<List<User>> GetAllUsers()
        {     
            var users = await _context.User.Include(u => u.Restaurant).ToListAsync();

            if (users != null)
            {
                return users;
            }
            else
            {
                return new List<User>();
            }
        }

        public async Task<int> UpdateUser(User user)
        {
            var userToUpdate = await GetUserById(user.Id);

            userToUpdate.Name = user.Name;
            userToUpdate.Role = user.Role;
            userToUpdate.FileName = user.FileName;
            userToUpdate.Email = user.Email;
            userToUpdate.Phone = user.Phone;
            userToUpdate.Password = user.Password;
            userToUpdate.Login = user.Login;
            userToUpdate.Restaurant = user.Restaurant;

            await _context.SaveChangesAsync();

            return userToUpdate.Id;
        }

        public async Task<int> DeleteUser(int id)
        {
            var userToDelete = await GetUserById(id);

            _context.User.Remove(userToDelete);
            await _context.SaveChangesAsync();

            return userToDelete.Id;
        }


    }
}
