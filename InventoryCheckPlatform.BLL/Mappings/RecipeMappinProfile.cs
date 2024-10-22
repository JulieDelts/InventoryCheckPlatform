using AutoMapper;
using InventoryCheckPlatform.Core.DTOs;
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCheckPlatform.BLL.Mappings
{
    public class RecipeMappinProfile :Profile
    {
        public RecipeMappinProfile()
        {
            CreateMap<ShortRecipeOutputModel, Recipe>();
            CreateMap<Recipe, ShortRecipeOutputModel>();
            CreateMap<RecipeInputModel, Recipe>();
            CreateMap<Recipe, RecipeOutputModel>();
            CreateMap<RecipeBaseProductAmount, BaseProductForRecipeInputModel>();
            CreateMap< BaseProductForRecipeInputModel, RecipeBaseProductAmount> ();


        }
    }
}
