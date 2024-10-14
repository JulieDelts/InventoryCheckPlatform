using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
    public class SysAdminUserManager
    {
        private List<FullUserOutputModel> _users;
        private List <ShortUserOutputModel> _shortUsers;

        public SysAdminUserManager()
        {
            // Инициализация списка пользователей
            _shortUsers = GetAllUsersShortInfo();
        }

        public List<ShortUserOutputModel> GetAllUsersShortInfo()
        {
            return new List<ShortUserOutputModel>
            {
                new ShortUserOutputModel()
                {
                    Id = 1,
                    Name = "Pasha",
                    RestaurantId = 1,
                    Role = "Admin"
                },

                new ShortUserOutputModel()
                {
                    Id = 2,
                    Name = "Sergey",
                    RestaurantId = 1,
                    Role = "Waiter"
                },
                new ShortUserOutputModel()

                {
                    Id = 3,
                    Name = "Igor",
                    RestaurantId = 3,
                    Role = "Waiter"
                },
                new ShortUserOutputModel()

                {
                    Id = 4,
                    Name = "Irina",
                    RestaurantId = 1,
                    Role = "Waiter"
                },
                new ShortUserOutputModel()
                {
                    Id = 5,
                    Name = "Olga",
                    RestaurantId = 1,
                    Role = "Waiter"
                },
                new ShortUserOutputModel()
                {
                    Id = 6,
                    Name = "Oleg",
                    RestaurantId = 0,
                    Role = "Logist"
                }
            };
        }

        public FullUserOutputModel GetUserById(int id)
        {
            var userList = new List<FullUserOutputModel>
            {

             new FullUserOutputModel()
                {
                Id = 1,
                Name = "Pavel Gubin ",
                Email = "kakoitoTam@mail.ru",
                Login = "pgubin",
                Password = "666",
                Role = "Admin",
                RestaurantId = 1
                },


              new FullUserOutputModel()
                {
                    Id = 2,
                    Name = "Sergey Trofimov",
                    Email = "gavgav@mail.ru",
                    Login = "strofimov",
                    Password = "ggg",
                    Role = "Admin",
                    RestaurantId = 2
                },


              new FullUserOutputModel()
              { Id = 3, Name = "Igor Petrov",
                  Email = "igor@mail.ru",
                  Login = "ipetrov",
                  Password = "123",
                  Role = "Waiter",
                 RestaurantId = 3
              },

                new FullUserOutputModel()
                { Id = 4, Name = "Irina Ivanova",
                    Email = "irina@mail.ru",
                    Login = "iivanova",
                    Password = "pass",
                    Role = "Waiter",
                    RestaurantId = 1
                },
                new FullUserOutputModel()
                { Id = 5, Name = "Olga Sidorova",
                    Email = "olga@mail.ru",
                    Login = "osidorova",
                    Password = "password",
                    Role = "Waiter",
                    RestaurantId = 1
                },
                new FullUserOutputModel()
                { Id = 6, Name = "Oleg Smirnov",
                    Email = "oleg@mail.ru",
                    Login = "osmnov",
                    Password = "abc",
                    Role = "Logist",
                    RestaurantId = 0
                }
            };
            return userList.FirstOrDefault(user => user.Id == id);
        }




        //TODO
        public void UpdateUser(FullUserOutputModel updatedUser)
        {
            var existingUser= _users.FirstOrDefault(u=> u.Id == updatedUser.Id);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Email = updatedUser.Email;
                existingUser.Login = updatedUser.Login;
                existingUser.Password = updatedUser.Password; 
                existingUser.Role = updatedUser.Role;
                existingUser.RestaurantId = updatedUser.RestaurantId;

            }
        }

        //TODO
        public void AddNewUser()
        { }
        //TODO
        public void DeleteUser()
        { }
    }
}
