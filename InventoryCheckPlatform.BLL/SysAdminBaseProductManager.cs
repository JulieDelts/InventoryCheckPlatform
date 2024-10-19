using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;

namespace InventoryCheckPlatform.BLL
{
    public class SysAdminBaseProductManager
    {
        private BaseProductRepository _baseProductRepository;

        private Mapper _mapper;
        public SysAdminBaseProductManager() 
        {
            _baseProductRepository = new();

            var config = new MapperConfiguration(
               cfg =>
               {
                   cfg.AddProfile(new BaseProductMapperProfile());
               });
            _mapper = new Mapper(config);
        } 
        public async Task<int> AddBaseProduct(BaseProductInputModel product)
        {
            try
            {
                var baseProductDTO = _mapper.Map<BaseProduct>(product);

                var baseProductId = await _baseProductRepository.AddBaseProduct(baseProductDTO);

                return baseProductId;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

        public async Task <List<BaseProductOutputModel>> GetAllBaseProducts()
        {
            var baseProducts = new List<BaseProductOutputModel>();

            try
            {
                var baseProductDTOs = await _baseProductRepository.GetAllBaseProducts();

                if (baseProductDTOs.Count > 0)
                {
                    foreach (var baseProductDTO in baseProductDTOs)
                    {
                        var baseProduct = _mapper.Map<BaseProductOutputModel>(baseProductDTO);

                        baseProducts.Add(baseProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

			return baseProducts;
        }
       
        public async Task<BaseProductOutputModel> GetBaseProductById(int id)
        {
            try
            {
                var baseProductDTO = await _baseProductRepository.GetBaseProductById(id);

                var baseProductResponse = _mapper.Map<BaseProductOutputModel>(baseProductDTO);

                return baseProductResponse;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return new BaseProductOutputModel();
			}
		}

        public async Task<int> UpdateBaseProduct(ExtendedBaseProductInputModel product)
        {
            try
            {
                var baseProductDTO = _mapper.Map<BaseProduct>(product);

                var id = await _baseProductRepository.UpdateBaseProduct(baseProductDTO);

                return id;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

        public async Task<int> DeleteBaseProduct(int id)
        {
            try
            {
                int baseProductId = await _baseProductRepository.DeleteBaseProduct(id);

                return baseProductId;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}
    }
}
