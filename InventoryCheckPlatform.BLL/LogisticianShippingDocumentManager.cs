using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;

namespace InventoryCheckPlatform.BLL
{
    public class LogisticianShippingDocumentManager
    {
		private Mapper _mapper;

        private LogisticianShippingDocumentRepository _shippingDocumentRepository;
		public LogisticianShippingDocumentManager()
        {
            _shippingDocumentRepository = new();

			var config = new MapperConfiguration(
			cfg =>
			{
				 cfg.AddProfile(new SpecificProductMapperProfile());
				 cfg.AddProfile(new ShippingDocumentMapperProfile());
				 cfg.AddProfile(new UserMapperProfile());
				 cfg.AddProfile(new RestaurantMapperProfile());
			});
			_mapper = new Mapper(config);
		}

        public async Task<int> AddShippingDocument(ShippingDocumentInputModel shippingDocument)
        {
			try
			{
				var shippingDocumentDTO = _mapper.Map<ShippingDocument>(shippingDocument);

				var shippingDocumentId = await _shippingDocumentRepository.AddShippingDocument(shippingDocumentDTO);

				return shippingDocumentId;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

		public async Task<List<ShippingDocumentOutputModel>> GetAllShippingDocuments()
		{
			var shippingDocuments = new List<ShippingDocumentOutputModel>();

			try
			{
				var shippingDocumentDTOs = await _shippingDocumentRepository.GetAllShippingDocuments();

				if (shippingDocumentDTOs.Count > 0)
				{
					foreach (var shippingDocumentDTO in shippingDocumentDTOs)
					{
						var shippingDocument = _mapper.Map<ShippingDocumentOutputModel>(shippingDocumentDTO);

						shippingDocuments.Add(shippingDocument);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return shippingDocuments;
		}

        public async Task<List<ShippingDocumentOutputModel>> GetAllShippingDocumentsByRestaurantId(int restaurantId)
        {
			var shippingDocuments = new List<ShippingDocumentOutputModel>();

			try
			{
				var shippingDocumentDTOs = await _shippingDocumentRepository.GetAllShippingDocumentsByRestaurantId(restaurantId);

				if (shippingDocumentDTOs.Count > 0)
				{
					foreach (var shippingDocumentDTO in shippingDocumentDTOs)
					{
						var shippingDocument = _mapper.Map<ShippingDocumentOutputModel>(shippingDocumentDTO);

						shippingDocuments.Add(shippingDocument);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return shippingDocuments;
		}

		public async Task<ShippingDocumentOutputModel> GetShippingDucumentById(int id)
		{
			try
			{
				var shippingDocumentDTO = await _shippingDocumentRepository.GetShippingDocumentById(id);

				var shippingDocumentResponse = _mapper.Map<ShippingDocumentOutputModel>(shippingDocumentDTO);

				return shippingDocumentResponse;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return new ShippingDocumentOutputModel();
			}
		}

		public async Task<int> UpdateShippingDocument(ExtendedShippingDocumentInputModel shippingDocument)
		{
			try
			{
				var shippingDocumentDTO = _mapper.Map<ShippingDocument>(shippingDocument);

				var id = await _shippingDocumentRepository.UpdateShippingDocument(shippingDocumentDTO);

				return id;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

		public async Task<int> DeleteShippingDocument(int id)
		{
			try
			{
				int shippingDocumentId = await _shippingDocumentRepository.DeleteShippingDocument(id);

				return shippingDocumentId;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return 0;
			}
		}

		public async Task<int> AddShippingDocumentSpecificProductAmount(ShippingDocumentSpecificProductAmountInputModel shippingDocumentSpecificProductAmount)
		{
            try
            {
                var shippingDocumentSpecificProductAmountDTO = _mapper.Map<ShippingDocumentSpecificProductAmount>(shippingDocumentSpecificProductAmount);

                var shippingDocumentId = await _shippingDocumentRepository.AddShippingDocumentSpecificProductAmount(shippingDocumentSpecificProductAmountDTO);

                return shippingDocumentId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return 0;
            }
        }


        public async Task<ShippingDocumentSpecificProductAmountOutputModel> GetShippingDocumentSpecificProductAmount(int specificProductId, int shippingDocumentId)
		{
			try
			{
				var shippingDocumentSpecificProductAmountDTO = await _shippingDocumentRepository.GetShippingDocumentSpecificProductAmount(specificProductId, shippingDocumentId);

				var shippingDocumentSpecificProductAmountResponse = _mapper.Map<ShippingDocumentSpecificProductAmountOutputModel>(shippingDocumentSpecificProductAmountDTO);

				return shippingDocumentSpecificProductAmountResponse;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);

				return new ShippingDocumentSpecificProductAmountOutputModel();
			}
		}

		public async Task DeleteShippingDocumentSpecificProductAmount(ShippingDocumentSpecificProductAmountInputModel shippingDocumentSpecificProductAmount)
		{
			try
			{
				var shippingDocumentSpecificProductAmountDTO = _mapper.Map<ShippingDocumentSpecificProductAmount>(shippingDocumentSpecificProductAmount);

				await _shippingDocumentRepository.DeleteShippingDocumentSpecificProductAmount(shippingDocumentSpecificProductAmountDTO);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
	
}
