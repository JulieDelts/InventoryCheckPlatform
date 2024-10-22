using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.BLL
{
    public class RecipteManager
    {
        private Mapper _mapper;

        private ReceiptRepository _receiptRepository;


        public RecipteManager ()
        {
            _receiptRepository = new ReceiptRepository();
            var config = new MapperConfiguration(
             cfg =>
             {
                 cfg.AddProfile(new RecipteMappingProfile());
                 cfg.AddProfile(new UserMapperProfile());
                

             });
            _mapper = new Mapper(config);

        }

        public async Task<int> AddRecipte (ReciptInputModel receipt)
        {
            try
            {
                var receiptDTO = _mapper.Map<Receipt>(receipt);

                var receiptId = await _receiptRepository.AddOrder(receiptDTO);

                return receiptId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return 0;
            }

        }
        public async Task<ReciptOutputModel> GetOrderById(int id)
        {
            try
            {
                var receiptDTO = await _receiptRepository.GetOrderById(id);

                var receiptResponse = _mapper.Map<ReciptOutputModel>(receiptDTO);

                return receiptResponse;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return new ReciptOutputModel();
            }

        }

        public async Task<int> DeleteOrder (int id)
        {
            try
            {
                int receiptId = await _receiptRepository.DeleteReceipte(id);

                return receiptId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return 0;
            }

        }
        public void AddPositionToOrder (int receiptId, int positionId)
        {
          
            //var order = _receiptRepository.GetOrderById(receiptId).Result; 
            //if (order == null)
            //{
            //    throw new Exception("Order not found");
            //}

            
            //var position = _receiptRepository.(positionId).Result; // Предполагаем наличие такого метода
            //if (position == null)
            //{
            //    throw new Exception("Position not found");
            //}

            //// Добавляем позицию к заказу
            //order.Positions.Add(position);

            //// Сохраняем изменения
            //_orderRepository.UpdateOrder(order);

        }

        public void RemovePositionToReceipt (int receiptId, int positionId)
        {
    
            var receipt = _receiptRepository.GetOrderById(receiptId).Result;
            if (receipt == null)
            {
                throw new Exception("Order not found");
            }

            
            var position = receipt.ReceiptRecipeAmounts.FirstOrDefault(p => p.Id == positionId);
            if (position == null)
            {
                throw new Exception("Position not found in the order");
            }

            receipt.ReceiptRecipeAmounts.Remove(position);

            _receiptRepository.UpdateOrder(receipt);

        }

        public async Task<List<ReciptOutputModel>> GetAllReceiptsAsync()
        {
            try
            {
                var receiptDTOs = await _receiptRepository.GetAllRecriptAsync();
                var receiptResponses = _mapper.Map<List<ReciptOutputModel>>(receiptDTOs);

                return receiptResponses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<ReciptOutputModel>(); 
            }
        }


    }
}
