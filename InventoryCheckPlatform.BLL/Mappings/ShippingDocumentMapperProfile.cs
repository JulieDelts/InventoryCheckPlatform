using AutoMapper;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL.Mappings
{
    public class ShippingDocumentMapperProfile: Profile
    {
        public ShippingDocumentMapperProfile()
        {
            CreateMap<ShippingDocumentInputModel, ShippingDocument>()
                 .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => new Restaurant { Id = src.RestaurantId }))
                 .ForMember(dest => dest.Logistician, opt => opt.MapFrom(src => new User { Id = src.LogisticianId }));
			CreateMap<ExtendedShippingDocumentInputModel, ShippingDocument>()
				 .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => new Restaurant { Id = src.RestaurantId }))
				 .ForMember(dest => dest.Logistician, opt => opt.MapFrom(src => new User { Id = src.LogisticianId }));
			CreateMap<ShippingDocumentSpecificProductAmountInputModel, ShippingDocumentSpecificProductAmount>()
                .ForMember(dest => dest.SpecificProduct, opt => opt.MapFrom(src => new SpecificProduct { Id = src.SpecificProductId }))
                .ForMember(dest => dest.ShippingDocument, opt => opt.MapFrom(src => new ShippingDocument { Id = src.ShippingDocumentId }));
            CreateMap<ShippingDocument, ShippingDocumentOutputModel>();
            CreateMap<ShippingDocumentSpecificProductAmount, ShippingDocumentSpecificProductAmountOutputModel>();
        }
    }
}
