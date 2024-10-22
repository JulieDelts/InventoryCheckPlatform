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
    public class RecipteMappingProfile : Profile
    {
        public RecipteMappingProfile()
        {
            CreateMap<RecipeInputModel, Receipt>();
            CreateMap<Receipt, RecipeOutputModel>();

        }
    }
}
