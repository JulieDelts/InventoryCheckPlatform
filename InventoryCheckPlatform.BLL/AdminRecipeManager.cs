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
        private List<MenuRecipeOutputModel> _recipes;
        private List<BasePoductOutputModel> _products;
        public AdminRecipeManager()
        {

            _recipes = new List<MenuRecipeOutputModel>
            {

                new MenuRecipeOutputModel
                {
                    Id=1,
                    Title= "Спагетти карбонара",
                    Ingredients = new List<BasePoductOutputModel>
                    {
                        new BasePoductOutputModel  { Id = 1, Name = "Спагетти", Category = "Бакалея"},
                    new BasePoductOutputModel { Id = 2, Name = "Яйца", Category = "какая-то категория" },
                    new BasePoductOutputModel { Id = 3, Name = "Пармезан",Category = "молочное" },
                    new BasePoductOutputModel { Id = 4, Name = "Бекон", Category = "мяско" }

                    }

                },
                new MenuRecipeOutputModel
                {
                    Id=2,
                    Title= "Цезарь",
                    Ingredients = new List<BasePoductOutputModel>
                    {
                        new BasePoductOutputModel  { Id = 5, Name = "Курица", Category = "мяско"},
                    new BasePoductOutputModel { Id = 6, Name = "Салат ", Category = "зеленуха" },
                    new BasePoductOutputModel { Id = 7, Name = "Гренки",Category = "хлебушек" },
                    new BasePoductOutputModel { Id = 8, Name = "Соус Цезарь", Category = "соусы" }

                    }

                },

            };
        }
            public List<MenuRecipeOutputModel> GetAllRecipes()
            {
                return _recipes;
            }
        public void AddRecipe(MenuRecipeOutputModel newRecipe)
        {

        }

        public void DeleteRecipe(int id)
        {

        }

    }

}


