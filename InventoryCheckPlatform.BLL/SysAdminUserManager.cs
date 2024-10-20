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
					cfg.AddProfile(new RestaurantMapperProfile());
				});
			_mapper = new Mapper(config);
		}

		public async Task<int> AddUser(UserInputModel user)
		{
			try
			{
				var userDTO = _mapper.Map<User>(user);

				var userId = await _userRepository.AddUser(userDTO);

				return userId;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

		public async Task<List<ShortUserOutputModel>> GetAllUsersShortInfo()
		{
			var users = new List<ShortUserOutputModel>();

			try
			{
				var userDTOs = await _userRepository.GetAllUsers();

				if (userDTOs.Count > 0)
				{
					foreach (var userDTO in userDTOs)
					{
						var user = _mapper.Map<ShortUserOutputModel>(userDTO);
						users.Add(user);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return users;
		}

		public async Task<FullUserOutputModel> GetUserById(int id)
		{
			try
			{
				var userDTO = await _userRepository.GetUserById(id);

				var userResponse = _mapper.Map<FullUserOutputModel>(userDTO);

				return userResponse;

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return new FullUserOutputModel();
			}
		}

		public async Task<int> UpdateUser(ExtendedUserInputModel updatedUser)
		{
			try
			{
				var userDTO = _mapper.Map<User>(updatedUser);

				var id = await _userRepository.UpdateUser(userDTO);

				return id;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

		public async Task<int> DeleteUser(int id)
		{
			try
			{
				int userId = await _userRepository.DeleteUser(id);

				return userId;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

			    return 0;
			}
		}
	}
}
