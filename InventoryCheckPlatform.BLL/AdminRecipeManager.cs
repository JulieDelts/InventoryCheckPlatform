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
        private List<BaseProductOutputModel> _products;
        public AdminRecipeManager()
        {

            _recipes = new List<MenuRecipeOutputModel>
            {

                new MenuRecipeOutputModel
                {
                    Id=1,
                    Title= "Спагетти карбонара",
                    Ingredients = new List<BaseProductOutputModel>
                    {
                        new BaseProductOutputModel  { Id = 1, Name = "Спагетти", Category = "Бакалея"},
                    new BaseProductOutputModel { Id = 2, Name = "Яйца", Category = "какая-то категория" },
                    new BaseProductOutputModel { Id = 3, Name = "Пармезан",Category = "молочное" },
                    new BaseProductOutputModel { Id = 4, Name = "Бекон", Category = "мяско" }

                    }

                },
                new MenuRecipeOutputModel
                {
                    Id=2,
                    Title= "Цезарь",
                    Ingredients = new List<BaseProductOutputModel>
                    {
                        new BaseProductOutputModel  { Id = 5, Name = "Курица", Category = "мяско"},
                    new BaseProductOutputModel { Id = 6, Name = "Салат ", Category = "зеленуха" },
                    new BaseProductOutputModel { Id = 7, Name = "Гренки",Category = "хлебушек" },
                    new BaseProductOutputModel { Id = 8, Name = "Соус Цезарь", Category = "соусы" }

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


