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
            CreateMap<RestaurantInputModel, Restaurant>()
               .ForMember(dest => dest.Admin, opt => opt.MapFrom(src => new Restaurant { Id = src.AdminId }));
            CreateMap<ExtendedRestaurantInputModel, Restaurant>()
                .ForMember(dest => dest.Admin, opt => opt.MapFrom(src => new Restaurant { Id = src.AdminId }));
            CreateMap<Restaurant, RestaurantOutputModel>()
                .ForMember(dest => dest.Admin, opt => opt.MapFrom(src => src.Admin));
        }
    }
}
