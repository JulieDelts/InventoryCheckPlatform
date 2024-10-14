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
                Ingredients = new List<BaseProductOutputModel>
                    {
                        new BaseProductOutputModel  { Id = 5, Name = "Курица", Category = "мяско"},
                    new BaseProductOutputModel { Id = 6, Name = "Салат ", Category = "зеленуха" },
                    new BaseProductOutputModel { Id = 7, Name = "Гренки",Category = "хлебушек" },
                    new BaseProductOutputModel { Id = 8, Name = "Соус Цезарь", Category = "соусы" }

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

    }
}

    




