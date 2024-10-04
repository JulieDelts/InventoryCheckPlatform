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
                    UserRole = "Admin"
                },

                new ShortUserOutputModel()
                {
                    Id = 2,
                    Name = "Sergey",
                    RestaurantId = 1,
                    UserRole = "Waiter"
                },
                new ShortUserOutputModel()

                {
                    Id = 3,
                    Name = "Igor",
                    RestaurantId = 3,
                    UserRole = "Waiter"
                },
                new ShortUserOutputModel()

                {
                    Id = 4,
                    Name = "Irina",
                    RestaurantId = 1,
                    UserRole = "Waiter"
                },
                new ShortUserOutputModel()
                {
                    Id = 5,
                    Name = "Olga",
                    RestaurantId = 1,
                    UserRole = "Waiter"
                },
                new ShortUserOutputModel()
                {
                    Id = 6,
                    Name = "Oleg",
                    RestaurantId = 0,
                    UserRole = "Logist"
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
                Mail = "kakoitoTam@mail.ru",
                Login = "pgubin",
                Password = "666",
                UserRole = "Admin",
                RestaurantId = 1
                },


              new FullUserOutputModel()
                {
                    Id = 2,
                    Name = "Sergey Trofimov",
                    Mail = "gavgav@mail.ru",
                    Login = "strofimov",
                    Password = "ggg",
                    UserRole = "Admin",
                    RestaurantId = 2
                },


              new FullUserOutputModel()
              { Id = 3, Name = "Igor Petrov",
                  Mail = "igor@mail.ru",
                  Login = "ipetrov",
                  Password = "123",
                  UserRole = "Waiter",
                 RestaurantId = 3
              },

                new FullUserOutputModel()
                { Id = 4, Name = "Irina Ivanova",
                    Mail = "irina@mail.ru",
                    Login = "iivanova",
                    Password = "pass",
                    UserRole = "Waiter",
                    RestaurantId = 1
                },
                new FullUserOutputModel()
                { Id = 5, Name = "Olga Sidorova",
                    Mail = "olga@mail.ru",
                    Login = "osidorova",
                    Password = "password",
                    UserRole = "Waiter",
                    RestaurantId = 1
                },
                new FullUserOutputModel()
                { Id = 6, Name = "Oleg Smirnov",
                    Mail = "oleg@mail.ru",
                    Login = "osmnov",
                    Password = "abc",
                    UserRole = "Logist",
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
                existingUser.Mail = updatedUser.Mail;
                existingUser.Login = updatedUser.Login;
                existingUser.Password = updatedUser.Password; 
                existingUser.UserRole = updatedUser.UserRole;
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
