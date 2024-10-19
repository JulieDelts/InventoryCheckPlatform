using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;

namespace InventoryCheckPlatform.BLL
{
	public class SysAdminRestaurantManager
	{
        private Mapper _mapper;

		private RestaurantRepository _restaurantRepository;

        private UserRepository _userRepository;

		public SysAdminRestaurantManager()
		{
			_restaurantRepository = new();

            _userRepository = new();

            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new RestaurantMapperProfile());
                    cfg.AddProfile(new UserMapperProfile());
                });
            _mapper = new Mapper(config);
        }

		public async Task<int> AddRestaurant(RestaurantInputModel restaurant)
		{
            try
            {
                var restaurantDTO = _mapper.Map<Restaurant>(restaurant);

                var restaurantId = await _restaurantRepository.AddRestaurant(restaurantDTO);

                return restaurantId;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

        public async Task<List<RestaurantOutputModel>> GetAllRestaurants()
		{
            var restaurants = new List<RestaurantOutputModel>();

            try
            {
                var restaurantDTOs = await _restaurantRepository.GetAllRestaurants();

                if (restaurantDTOs.Count > 0)
                {
                    foreach (var restaurantDTO in restaurantDTOs)
                    {
                        var restaurant = _mapper.Map<RestaurantOutputModel>(restaurantDTO);

                        var adminDTO = await _restaurantRepository.GetAdminByRestaurantId(restaurantDTO.Id);

                        if (adminDTO != null)
                        {
                            var admin = _mapper.Map<FullUserOutputModel>(adminDTO);

                            restaurant.Admin = admin;
                        }

                        restaurants.Add(restaurant);
                    }
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }

            return restaurants;
        }

        public async Task<RestaurantOutputModel> GetRestaurantById(int id)
		{
            try
            {
                var restaurantDTO = await _restaurantRepository.GetRestaurantById(id);

                var restaurantResponse = _mapper.Map<RestaurantOutputModel>(restaurantDTO);

                var adminDTO = await _restaurantRepository.GetAdminByRestaurantId(id);

                if (adminDTO != null)
                {
                    var admin = _mapper.Map<FullUserOutputModel>(adminDTO);

                    restaurantResponse.Admin = admin;
                }

                return restaurantResponse;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return new RestaurantOutputModel();
			}
		}

		public async Task<int> UpdateRestaurant(ExtendedRestaurantInputModel updatedRestaurant)
		{
            try
            {
                var restaurantDTO = _mapper.Map<Restaurant>(updatedRestaurant);

                var id = await _restaurantRepository.UpdateRestaurant(restaurantDTO);

                return id;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

		public async Task<int> DeleteRestaurant(int id)
		{
            try
            {
                int restaurantId = await _restaurantRepository.DeleteRestaurant(id);

                return restaurantId;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}
	}
}
