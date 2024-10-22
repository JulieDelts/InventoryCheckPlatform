using AutoMapper;
using InventoryCheckPlatform.BLL.Mappings;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using InventoryCheckPlatform.DAL; 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.BLL
{
    public class AdminRecipeManager
    {
        private readonly RecipeRepository _recipeRepository;
        private readonly BaseProductRepository _productRepository;
        private Mapper _mapper;

        public AdminRecipeManager()
        {
            _recipeRepository = new();

            _productRepository = new();

            var config = new MapperConfiguration(
               cfg =>
               {
                   cfg.AddProfile(new RecipeMappinProfile());
                   cfg.AddProfile(new BaseProductMapperProfile());
               });
            _mapper = new Mapper(config);
        }



        public async Task<RecipeOutputModel> GetRecipeByIdAsync(int id)
        {
            var recipe = await _recipeRepository.GetRecipeById(id);
            if (recipe == null) return null; //выбросить исключение
            var result = _mapper.Map<RecipeOutputModel>(recipe);
            result.RecipeBaseProductAmount = new();
            foreach (var item in recipe.RecipeBaseProductAmounts)
            {
                result.RecipeBaseProductAmount.Add(new BaseProductForRecipeInputModel { Id = item.Id, Name = item.BaseProduct.Name, Amount = item.ProductAmount.ToString() });
            }
            return result;
        }

        public async Task<List<BaseProductForRecipeOutputModel>> GetAllProductsAsync ()
        {
            var recipes = await _productRepository.GetAllBaseProducts();
            return _mapper.Map<List<BaseProductForRecipeOutputModel>>(recipes);
        }

        public async Task<List<ShortRecipeOutputModel>> GetAllRecipesShortAsync()
        {
            var recipes = await _recipeRepository.GetAllRecipes();
            return _mapper.Map<List<ShortRecipeOutputModel>>(recipes);
        }

        public async Task AddRecipeAsync(RecipeOutputModel newRecipe)
        {
            if (newRecipe == null) throw new ArgumentNullException(nameof(newRecipe));

            var recipeEntity = new Recipe {Name=newRecipe.Name, ReceiptRecipeAmounts=new(),RecipeBaseProductAmounts=new(), Restaurant=new Restaurant {Id=2,Address="111"} }; 

            foreach (var ingredient in newRecipe.RecipeBaseProductAmount)
            {
                var baseProduct = await _productRepository.GetBaseProductById(ingredient.Id); 
                if (baseProduct != null)
                {
                    recipeEntity.RecipeBaseProductAmounts.Add(new RecipeBaseProductAmount
                    {
                        BaseProduct = baseProduct,
                        ProductAmount = int.Parse(ingredient.Amount) 
                    });
                }
                else
                {
                    throw new InvalidOperationException($"Base product with ID {ingredient.Id} not found.");
                }
            }

            await _recipeRepository.AddRecipe(recipeEntity);
        }
        //public async Task<List<BaseProductForRecipeOutputModel>> GetAllProductsAsync()
        //{
        //    var baseproduct= _productRepository.GetAllBaseProducts();
        //    return baseproduct.Result.Select(x => new BaseProductForRecipeOutputModel { Id = x.Id, Name = x.Name, Count =0}).ToList();
        //}
    }


}
    


    




