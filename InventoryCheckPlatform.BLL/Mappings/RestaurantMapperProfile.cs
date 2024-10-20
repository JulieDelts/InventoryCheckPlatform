using AutoMapper;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL.Mappings
{
    public class RestaurantMapperProfile: Profile
    {
        public RestaurantMapperProfile()
        {
            CreateMap<RestaurantInputModel, Restaurant>();
            CreateMap<ExtendedRestaurantInputModel, Restaurant>();
            CreateMap<Restaurant, RestaurantOutputModel>();
        }
    }
}
