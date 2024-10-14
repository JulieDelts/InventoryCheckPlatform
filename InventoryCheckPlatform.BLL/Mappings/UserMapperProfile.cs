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
                .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => new User { Id = (int)src.RestaurantId }));
            CreateMap<ExtendedUserInputModel, User>()
                .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => new User { Id = (int)src.RestaurantId }));
            CreateMap<User, ShortUserOutputModel>()
                .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant.Id));
            CreateMap<User, FullUserOutputModel>()
               .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant.Id));
        }
    }
        
}
