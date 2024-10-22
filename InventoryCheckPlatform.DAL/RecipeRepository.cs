using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core;
using InventoryCheckPlatform.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryCheckPlatform.DAL
{
    public class RecipeRepository
    {
        private InventoryCheckContext _context;

        public RecipeRepository()
        {
            _context = new InventoryCheckContext();
        }

        public async Task<int> AddRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }
            foreach (var item in recipe.RecipeBaseProductAmounts)
            {
                _context.Attach(item.BaseProduct);
            }
            recipe.Restaurant = await _context.Restaurant.FirstOrDefaultAsync();
            await _context.Recipe.AddAsync(recipe);
            await _context.SaveChangesAsync();

            return recipe.Id;
        }

        public async Task<Recipe> GetRecipeById(int id)
        {
            return await _context.Recipe.Where(s => s.Id == id).Include(r => r.RecipeBaseProductAmounts)
                .ThenInclude(rbpa => rbpa.BaseProduct)
                .FirstOrDefaultAsync();
                
               
        }
        public async Task<List<Recipe>> GetAllRecipes()
        {
            return await _context.Recipe.Include(r => r.RecipeBaseProductAmounts).ToListAsync(); 
        }

        public async Task UpdateRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            _context.Recipe.Update(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecipe(int id)
        {
            var recipe = await GetRecipeById(id);
            if (recipe == null)
            {
                throw new Exception("Recipe not found");
            }

            _context.Recipe.Remove(recipe);
            await _context.SaveChangesAsync();
        }

    }



}
