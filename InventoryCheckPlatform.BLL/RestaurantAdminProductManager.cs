using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;

namespace InventoryCheckPlatform.BLL
{
    public class RestaurantAdminProductManager
    {
        private Mapper _mapper;

        private RestaurantAdminSpecificProductRepository _specificProductAmountRepository;

        public RestaurantAdminProductManager()
        {
            _specificProductAmountRepository = new();

            var config = new MapperConfiguration(
               cfg =>
               {
                   cfg.AddProfile(new SpecificProductMapperProfile());
                   cfg.AddProfile(new RestaurantMapperProfile());
               });
            _mapper = new Mapper(config);
        }

        public async Task AddSpecificProductsToRestaurant(List<RestaurantSpecificProductAmountInputModel> productAmounts)
        {
            var productAmountDTOs = new List<RestaurantSpecificProductAmount>();

            try
            {
                if (productAmounts.Count > 0)
                {
                    foreach (var productAmount in productAmounts)
                    {
                        var productAmountDTO = _mapper.Map<RestaurantSpecificProductAmount>(productAmount);

                        productAmountDTOs.Add(productAmountDTO);
                    }
                }

                await _specificProductAmountRepository.AddSpecificProductsToRestaurant(productAmountDTOs);

            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }

        public async Task <List<RestaurantSpecificProductAmountOutputModel>> GetAllSpecificProductsWithAmount(int restaurantId)
        {
            var specificProductsWithAmount = new List<RestaurantSpecificProductAmountOutputModel>();

            try
            {
                var specificProductDTOsWithAmount = await _specificProductAmountRepository.GetAllSpecificProductsByRestaurantId(restaurantId);

                if (specificProductDTOsWithAmount.Count > 0)
                {
                    foreach (var specificProductDTOWithAmount in specificProductDTOsWithAmount)
                    {
                        var specificProductWithAmount = _mapper.Map<RestaurantSpecificProductAmountOutputModel>(specificProductDTOWithAmount);

                        specificProductsWithAmount.Add(specificProductWithAmount);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return specificProductsWithAmount;
        }

        public async Task<RestaurantSpecificProductAmountOutputModel> GetSpecificProductAmountById(int restaurantId, int productId)
        {
            try
            {
                var specificProductAmountDTO = await _specificProductAmountRepository.GetSpecificProductWithAmountById(restaurantId, productId);

                var specificProductAmount = _mapper.Map<RestaurantSpecificProductAmountOutputModel>(specificProductAmountDTO);

                return specificProductAmount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return new RestaurantSpecificProductAmountOutputModel();
            }
        }

        public async Task UpdateSpecificProductAmount(RestaurantSpecificProductAmountInputModel productAmount)
        {
            try
            {
                var specificProductAmountDTO = _mapper.Map<RestaurantSpecificProductAmount>(productAmount);

                await _specificProductAmountRepository.UpdateSpecificProductAmount(specificProductAmountDTO);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public async Task DeleteSpecificProduct(RestaurantSpecificProductAmountInputModel productAmount)
        {
            try
            {
                var specificProductAmountDTO = _mapper.Map<RestaurantSpecificProductAmount>(productAmount);

                await _specificProductAmountRepository.DeleteSpecificProduct(specificProductAmountDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
