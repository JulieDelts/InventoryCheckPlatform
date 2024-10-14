using AutoMapper;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL.Mappings
{
    public class BaseProductMapperProfile: Profile
    {
        public BaseProductMapperProfile()
        {
            CreateMap<BaseProductInputModel, BaseProduct>();
            CreateMap<ExtendedBaseProductInputModel, BaseProduct>();
            CreateMap<RecipeBaseProductAmountInputModel, RecipeBaseProductAmount>()
                .ForMember(dest => dest.Recipe, opt => opt.MapFrom(src => new Recipe { Id = src.RecipeId }))
                .ForMember(dest => dest.BaseProduct, opt => opt.MapFrom(src => new BaseProduct { Id = src.ProductId }));
            CreateMap<BaseProduct, BaseProductOutputModel>();
            CreateMap<RecipeBaseProductAmount, RecipeBaseProductAmountOutputModel>()
                .ForMember(dest => dest.RecipeId, opt => opt.MapFrom(src => src.Recipe.Id))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.BaseProduct.Id));
        }
    }
}
