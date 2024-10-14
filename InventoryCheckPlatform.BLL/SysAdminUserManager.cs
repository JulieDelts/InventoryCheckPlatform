using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;

namespace InventoryCheckPlatform.BLL
{
    public class SysAdminUserManager
    {
        private Mapper _mapper;

        private UserRepository _userRepository;
    
        public SysAdminUserManager()
        {
            _userRepository = new UserRepository();

            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new UserMapperProfile());
                });
            _mapper = new Mapper(config);
        } 
        
        public async Task<int> AddUser(UserInputModel user)
        {
            var userDTO = _mapper.Map<User>(user);

            var userId = await _userRepository.AddUser(userDTO);

            return userId;
        }

        public async Task<List<ShortUserOutputModel>> GetAllUsersShortInfo()
        {
            var userDTOs = await _userRepository.GetAllUsers();  

            var users = new List<ShortUserOutputModel>();

            foreach (var userDTO in userDTOs)
            {
                var user = _mapper.Map<ShortUserOutputModel>(userDTO);
                users.Add(user);
            }

            return users;   

            //return new List<ShortUserOutputModel>
            //{
            //    new ShortUserOutputModel()
            //    {
            //        Id = 1,
            //        Name = "Pasha",
            //        RestaurantId = 1,
            //        Role = "Admin"
            //    },

            //    new ShortUserOutputModel()
            //    {
            //        Id = 2,
            //        Name = "Sergey",
            //        RestaurantId = 1,
            //        Role = "Waiter"
            //    },
            //    new ShortUserOutputModel()

            //    {
            //        Id = 3,
            //        Name = "Igor",
            //        RestaurantId = 3,
            //        Role = "Waiter"
            //    },
            //    new ShortUserOutputModel()

            //    {
            //        Id = 4,
            //        Name = "Irina",
            //        RestaurantId = 1,
            //        Role = "Waiter"
            //    },
            //    new ShortUserOutputModel()
            //    {
            //        Id = 5,
            //        Name = "Olga",
            //        RestaurantId = 1,
            //        Role = "Waiter"
            //    },
            //    new ShortUserOutputModel()
            //    {
            //        Id = 6,
            //        Name = "Oleg",
            //        RestaurantId = 0,
            //        Role = "Logist"
            //    }
            //};
        }

        public async Task<FullUserOutputModel> GetUserById(int id)
        {
            var userDTO = await _userRepository.GetUserById(id);

            var userResponse = _mapper.Map<FullUserOutputModel>(userDTO);

            return userResponse;
        }

        public async Task<int> UpdateUser(ExtendedUserInputModel updatedUser)
        {
            var userDTO = _mapper.Map<User>(updatedUser);

            var id = await _userRepository.UpdateUser(userDTO);

            return id;
        }

        public async Task<int> DeleteUser(int id)
        {
            int userId = await _userRepository.DeleteUser(id);

            return userId;
        }
    }
}
