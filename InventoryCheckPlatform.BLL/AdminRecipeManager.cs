using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.BLL
{
    public class AdminRecipeManager
    {
        private List<ShortRecipeOutputModel> _recipes;
        private List<BaseProductOutputModel> _products;
        public AdminRecipeManager()
        {

            _recipes = new List<ShortRecipeOutputModel>
            {

                new ShortRecipeOutputModel
                {
                    Id=1,
                    Title= "Спагетти карбонара",

                },
                new ShortRecipeOutputModel
                {
                    Id=2,
                    Title= "Цезарь",

                },

            };
        }
        public async Task<RecipeOutputModel> GetRecipeByIdAsync(int id)
        {
            return new RecipeOutputModel()
            {
                Id = 2,
                Title = "Цезарь",
                Ingredients = new List<BaseProductForRecipeInputModel>
                    {
                        new BaseProductForRecipeInputModel  { Id = 5, Name = "Курица", Count="2"},
                    new BaseProductForRecipeInputModel { Id = 6, Name = "Салат ", Count="2"},
                    new BaseProductForRecipeInputModel { Id = 7, Name = "Гренки", Count="2"},
                    new BaseProductForRecipeInputModel { Id = 8, Name = "Соус Цезарь", Count="2"}

                    }

            };
        }
        public List<ShortRecipeOutputModel> GetAllRecipes()
        {
            return new List<ShortRecipeOutputModel>
            {
                new ShortRecipeOutputModel
                {
                    Id = 1,
                    Title = "Спагетти карбонара",

                },
                new ShortRecipeOutputModel
                {
                    Id = 2,
                    Title = "Цезарь",

                },
            };
        }
        public void AddRecipe(RecipeOutputModel newRecipe)
        {

        }

        public void DeleteRecipe(int id)
        {

        }
        public async Task<List<BaseProductForRecipeOutputModel>> GetAllProductsAsync()
        {
            return new List<BaseProductForRecipeOutputModel>()
            {
                        new BaseProductForRecipeOutputModel  { Id = 5, Name = "Курица"},
                    new BaseProductForRecipeOutputModel { Id = 6, Name = "Салат "},
                    new BaseProductForRecipeOutputModel { Id = 7, Name = "Гренки"},
                    new BaseProductForRecipeOutputModel { Id = 8, Name = "Соус Цезарь"}

                    

            };
        }

    }
}

    




