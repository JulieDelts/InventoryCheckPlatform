using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;

namespace InventoryCheckPlatform.BLL
{
    public class LogisticianProductManager
    {
        private LogisticianSpecificProductRepository _specificProductRepository;

        private BaseProductRepository _baseProductRepository;

        private Mapper _mapper;
        public LogisticianProductManager()
        {
            _specificProductRepository = new();

            _baseProductRepository = new();

            var config = new MapperConfiguration(
               cfg =>
               {
                   cfg.AddProfile(new SpecificProductMapperProfile());
                   cfg.AddProfile(new BaseProductMapperProfile());
               });
            _mapper = new Mapper(config);
        } 
        
        public async Task<int> AddSpecificProduct(SpecificProductInputModel product)
        {
            try
            {
                var specificProductDTO = _mapper.Map<SpecificProduct>(product);

                var specificProductId = await _specificProductRepository.AddSpecificProduct(specificProductDTO);

                return specificProductId;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

        public async Task<List<SpecificProductOutputModel>> GetAllSpecificProducts()
        {
            var specificProducts = new List<SpecificProductOutputModel>();

            try
            {
                var specificProductDTOs = await _specificProductRepository.GetAllSpecificProducts();

                if (specificProductDTOs.Count > 0) {

                    foreach (var specificProductDTO in specificProductDTOs)
                    {
                        var specificProduct = _mapper.Map<SpecificProductOutputModel>(specificProductDTO);

                        specificProducts.Add(specificProduct);
                    }
                }
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return specificProducts;
        }

        public async Task<SpecificProductOutputModel> GetSpecificProductById(int id)
        {
            try
            {
                var baseProductDTO = await _specificProductRepository.GetSpecificProductById(id);

                var baseProductResponse = _mapper.Map<SpecificProductOutputModel>(baseProductDTO);

                return baseProductResponse;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return new SpecificProductOutputModel();
			}
		}

        public async Task<int> UpdateSpecificProduct(ExtendedSpecificProductInputModel product)
        {
            try
            {
                var specificProductDTO = _mapper.Map<SpecificProduct>(product);

                var id = await _specificProductRepository.UpdateSpecificProduct(specificProductDTO);

                return id;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

        public async Task<int> DeleteSpecificProduct(int id)
        {
            try
            {
                int specificProductId = await _specificProductRepository.DeleteSpecificProduct(id);

                return specificProductId;
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}
    }
}
