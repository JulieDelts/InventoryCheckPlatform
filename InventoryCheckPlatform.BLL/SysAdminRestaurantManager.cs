using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
	public class SysAdminRestaurantManager
	{
		//TODO
		public List<RestaurantOutputModel> GetAllRestaurants()
		{
			return new List<RestaurantOutputModel>
			{
				new RestaurantOutputModel()
				{
					Id= 1,
					Address = "г. Мск, ул. Кк, д. 10",
					Admin = new() { Name = "Вася", Id = 7 }
				},
				new RestaurantOutputModel()
				{
					Id= 2,
					Address = "г. Петербург, ул. Дд, д. 11",
					Admin = new() { Name = "Петя", Id = 2 }
				}
			};
		}

		//TODO
		public RestaurantOutputModel GetRestaurantById(int id)
		{
			return new RestaurantOutputModel()
			{
				Id = 3,
				Address = "г. Казань, ул. ВВ, д. 13",
				Admin = new() { Name = "Женя", Id = 4 }
			};
		}

		//TODO
		public int AddNewRestaurant(RestaurantInputModel restaurant)
		{
			int id = 0;//обращаемся к методу дал

			return id;
		}

		//TODO
		public int UpdateRestaurant(ExtendedRestaurantInputModel restaurant)
		{
			int id = 0;//обращаемся к методу дал

			return id;
		}

		//TODO
		public void DeleteRestaurant(int id)
		{
			//обращаемся к методу дал
		}
	}
}
