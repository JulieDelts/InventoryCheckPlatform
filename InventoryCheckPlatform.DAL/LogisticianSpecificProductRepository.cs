using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
	public class LogisticianSpecificProductRepository
	{
		private InventoryCheckContext _context;

		public LogisticianSpecificProductRepository()
		{
			_context = new InventoryCheckContext();
		}

		public async Task<int> AddSpecificProduct(SpecificProduct specificProduct)
		{
			var baseProduct = await _context.BaseProduct.Where(bp => bp.Id == specificProduct.BaseProduct.Id).FirstOrDefaultAsync();

			if (baseProduct != null)
			{
				specificProduct.BaseProduct = baseProduct;

				_context.SpecificProduct.Add(specificProduct);

				await _context.SaveChangesAsync();

				return specificProduct.Id;
			}
			else
			{
				throw new Exception("The BaseProduct is not found.");
			}
		}

		public async Task<SpecificProduct> GetSpecificProductById(int id)
		{
			var specificProduct = await _context.SpecificProduct.Where(s => s.Id == id).Include(s => s.BaseProduct).FirstOrDefaultAsync();

			if (specificProduct != null)
			{
				return specificProduct;
			}
			else
			{
				throw new Exception("The product is not found.");
			}
		}

		public async Task<List<SpecificProduct>> GetAllSpecificProducts()
		{
			var specififcProducts = await _context.SpecificProduct.Include(s => s.BaseProduct).ToListAsync();

			if (specififcProducts != null)
			{
				return specififcProducts;
			}
			else
			{
				return new List<SpecificProduct>();
			}
		}

		public async Task<int> UpdateSpecificProduct(SpecificProduct specificProduct)
		{
			var specificProductToUpdate = await GetSpecificProductById(specificProduct.Id);

			specificProductToUpdate.Vendor = specificProduct.Vendor;
			specificProductToUpdate.Price = specificProduct.Price;
			specificProductToUpdate.FileName = specificProduct.FileName;

			await _context.SaveChangesAsync();

			return specificProductToUpdate.Id;
		}

		public async Task<int> DeleteSpecificProduct(int id)
		{
			var specificProductToDelete = await GetSpecificProductById(id);

			_context.SpecificProduct.Remove(specificProductToDelete);
			await _context.SaveChangesAsync();

			return specificProductToDelete.Id;
		}
	}
}
