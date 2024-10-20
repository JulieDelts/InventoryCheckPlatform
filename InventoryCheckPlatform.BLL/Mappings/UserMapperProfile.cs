using AutoMapper;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL.Mappings
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile() 
        {
            CreateMap<UserInputModel, User>()
                .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => src.RestaurantId.HasValue ? new Restaurant { Id = (int)src.RestaurantId } : null));
            CreateMap<ExtendedUserInputModel, User>()
                .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => src.RestaurantId.HasValue ? new Restaurant { Id = (int)src.RestaurantId } : null));
            CreateMap<User, ShortUserOutputModel>()
                .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant != null ? src.Restaurant.Id : (int?)null));
            CreateMap<User, FullUserOutputModel>()
               .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant != null ? src.Restaurant.Id : (int?)null));
        }
    }
        
}
