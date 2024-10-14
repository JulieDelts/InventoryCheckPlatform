
using AutoMapper;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL.Mappings
{
    public class SpecificProductMapperProfile: Profile
    {
        public SpecificProductMapperProfile()
        {
            CreateMap<SpecificProductInputModel, SpecificProduct>()
                .ForMember(dest => dest.BaseProduct, opt => opt.MapFrom(src => new BaseProduct { Id = src.BaseProductId }));
            CreateMap<ExtendedSpecificProductInputModel, SpecificProduct>()
                .ForMember(dest => dest.BaseProduct, opt => opt.MapFrom(src => new BaseProduct { Id = src.BaseProductId }));
            CreateMap<RestaurantSpecificProductAmountInputModel, RestaurantSpecificProductAmount>()
                .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => new Restaurant { Id = src.RestaurantId }))
                .ForMember(dest => dest.SpecificProduct, opt => opt.MapFrom(src => new SpecificProduct { Id = src.SpecificProductId }));
            CreateMap<SpecificProduct, SpecificProductOutputModel>()
                .ForMember(dest => dest.BaseProduct, opt => opt.MapFrom(src => src.BaseProduct));
            CreateMap<RestaurantSpecificProductAmount, RestaurantSpecificProductAmountOutputModel>()
                .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant.Id))
                .ForMember(dest => dest.SpecificProductId, opt => opt.MapFrom(src => src.SpecificProduct.Id));
        }
    }
}
