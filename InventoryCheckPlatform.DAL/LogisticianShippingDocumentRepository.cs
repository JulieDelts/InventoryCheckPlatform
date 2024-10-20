
using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
	public class LogisticianShippingDocumentRepository
	{
		private InventoryCheckContext _context;

		public LogisticianShippingDocumentRepository()
		{
			_context = new InventoryCheckContext();
		}

		public async Task<int> AddShippingDocument(ShippingDocument shippingDocument)
		{
			var logistician = await _context.User.Where(u => u.Id == shippingDocument.Logistician.Id).FirstOrDefaultAsync();

			var restaurant = await _context.Restaurant.Where(r => r.Id == shippingDocument.Restaurant.Id).FirstOrDefaultAsync();

			if (logistician != null && restaurant != null)
			{
				shippingDocument.Logistician = logistician;

				shippingDocument.Restaurant = restaurant;

				_context.ShippingDocument.Add(shippingDocument);

				await _context.SaveChangesAsync();

				return shippingDocument.Id;
			}
			else
			{
				throw new Exception("The entities are not found.");
			}
		}

		public async Task<ShippingDocument> GetShippingDocumentById(int id)
		{
			var shippingDocument = await _context.ShippingDocument.Where(s => s.Id == id).Include(s => s.Logistician).Include(s => s.Restaurant).Include(s => s.ShippingDocumentSpecificProductAmounts).ThenInclude(sa => sa.SpecificProduct).FirstOrDefaultAsync();

			if (shippingDocument != null)
			{
				return shippingDocument;
			}
			else
			{
				throw new Exception("The shipping document is not found.");
			}
		}

		public async Task<List<ShippingDocument>> GetAllShippingDocuments()
		{
			var shippingDocuments = await _context.ShippingDocument.Include(s => s.Logistician).Include(s => s.Restaurant).Include(s => s.ShippingDocumentSpecificProductAmounts).ThenInclude(sa => sa.SpecificProduct).ToListAsync();

			if (shippingDocuments != null)
			{
				return shippingDocuments;
			}
			else
			{
				return new List<ShippingDocument>();
			}
		}

		public async Task<List<ShippingDocument>> GetAllShippingDocumentsByRestaurantId(int restaurantId)
		{
			var shippingDocuments = await _context.ShippingDocument.Where(s => s.Restaurant.Id == restaurantId).Include(s => s.Logistician).Include(s => s.Restaurant).Include(s => s.ShippingDocumentSpecificProductAmounts).ThenInclude(sa => sa.SpecificProduct).ToListAsync();

			if (shippingDocuments != null)
			{
				return shippingDocuments;
			}
			else
			{
				return new List<ShippingDocument>();
			}
		}

		public async Task<int> UpdateShippingDocument(ShippingDocument shippingDocument)
		{
			var shippingDocumentToUpdate = await GetShippingDocumentById(shippingDocument.Id);

			shippingDocumentToUpdate.Status = shippingDocument.Status;
			shippingDocumentToUpdate.DeliveryDate = shippingDocument.DeliveryDate;

			await _context.SaveChangesAsync();

			return shippingDocumentToUpdate.Id;
		}

		public async Task<int> DeleteShippingDocument(int id)
		{
			var shippingDocumentToDelete = await GetShippingDocumentById(id);

			_context.ShippingDocument.Remove(shippingDocumentToDelete);
			await _context.SaveChangesAsync();

			return shippingDocumentToDelete.Id;
		}

		public async Task<int> AddShippingDocumentSpecificProductAmount(ShippingDocumentSpecificProductAmount shippingDocumentSpecificProductAmount)
		{
			var shippingDocument = await _context.ShippingDocument.Where(sd => sd.Id == shippingDocumentSpecificProductAmount.ShippingDocument.Id).FirstOrDefaultAsync();

			var specificProduct = await _context.SpecificProduct.Where(sp => sp.Id == shippingDocumentSpecificProductAmount.SpecificProduct.Id).FirstOrDefaultAsync();

			if (shippingDocument != null && specificProduct != null)
			{
				shippingDocumentSpecificProductAmount.SpecificProduct = specificProduct;

				shippingDocumentSpecificProductAmount.ShippingDocument = shippingDocument;

				_context.ShippingDocumentSpecificProductAmount.Add(shippingDocumentSpecificProductAmount);

				await _context.SaveChangesAsync();

				return shippingDocument.Id;
			}
			else
			{
				throw new Exception("The entities are not found.");
			}
		}

		public async Task<ShippingDocumentSpecificProductAmount> GetShippingDocumentSpecificProductAmount(int specificProductId, int shippingDocumentId)
		{
			var shippingDocumentSpecificProductAmount = await _context.ShippingDocumentSpecificProductAmount.Where(s => s.SpecificProduct.Id == specificProductId && s.ShippingDocument.Id == shippingDocumentId).Include(s => s.ShippingDocument).Include(s => s.SpecificProduct).FirstOrDefaultAsync();

			if (shippingDocumentSpecificProductAmount != null)
			{
				return shippingDocumentSpecificProductAmount;
			}
			else
			{
				throw new Exception("The entity is not found.");
			}
		}

		public async Task DeleteShippingDocumentSpecificProductAmount(ShippingDocumentSpecificProductAmount shippingDocumentSpecificProductAmount)
		{
			var shippingDocumentSpecificProductAmountToDelete = await GetShippingDocumentSpecificProductAmount(shippingDocumentSpecificProductAmount.SpecificProduct.Id, shippingDocumentSpecificProductAmount.ShippingDocument.Id);

			_context.ShippingDocumentSpecificProductAmount.Remove(shippingDocumentSpecificProductAmountToDelete);
			await _context.SaveChangesAsync();
		}
	}
}
