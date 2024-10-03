using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
    public class SysAdminUserManager
    {
        //private List<ShortUserOutputModel> _users;

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
            if (id % 2 == 0)
            {
                return new FullUserOutputModel()
                {
                    Id = id,
                    Name = "Pavel Gubin ",
                    Mail = "kakoitoTam@mail.ru",
                    Login = "pgubin",
                    Password = "666",
                    UserRole = "Admin",
                    RestaurantId = 1
                };
            }
            else
            {
                return new FullUserOutputModel()
                {
                    Id = id,
                    Name = "Sergey Trofimov",
                    Mail = "gavgav@mail.ru",
                    Login = "strofimov",
                    Password = "ggg",
                    UserRole = "Admin",
                    RestaurantId = 2
                };
            }
        }

        //TODO
        public void UpdateUser(FullUserOutputModel updatedUser)
        { }

        //TODO
        public void AddNewUser()
        { }
        //TODO
        public void DeleteUser()
        { }
    }
}
