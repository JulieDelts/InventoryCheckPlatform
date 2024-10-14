using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
    public class SysAdminBaseProductManager
    {
        //TODO
        public List<BaseProductOutputModel> GetAllBaseProducts()
        {
            return new List<BaseProductOutputModel>
            {
                new BaseProductOutputModel()
                {
                    Id= 1,
                    Name="банан",
                    Category = "фрукт"

                },
                new BaseProductOutputModel()
                {
                    Id=2,
                    Name="картошечка",
                    Category = "овощ"
                },
                new BaseProductOutputModel()
                {
                    Id=3,
                    Name="шампиньончик",
                    Category = "грибочек"
                },
                  new BaseProductOutputModel()
                {
                    Id=4,
                    Name="молоко",
                    Category = "молочные"
                },
                new BaseProductOutputModel()
                {
                    Id=5,
                    Name="сырочек",
                    Category = "молочные"
                },
                new BaseProductOutputModel()
                {
                    Id=6,
                    Name="хлебушке",
                    Category = "мучное"
                },
                new BaseProductOutputModel()
                {
                    Id=7,
                    Name="ананасик",
                    Category = "фрукт"
                },
                new BaseProductOutputModel()
                {
                    Id=8,
                    Name="лосось",
                    Category = "рыбное"
                },
                new BaseProductOutputModel()
                {
                    Id=9,
                    Name="говядина",
                    Category = "мясное"
                },
                new BaseProductOutputModel()
                {
                    Id=10,
                    Name="джин",
                    Category = "алкоголь"
                }
            };
        }

        //TODO
        public BaseProductOutputModel GetBaseProductById(int id)
        {
            return new BaseProductOutputModel()
            {
                Id = id,
                Name = "малина",
                Category = "ягоды"
            };
        }

        //TODO
        public int AddNewBaseProduct(BaseProductInputModel product)
        {
            int id = 0;//обращаемся к методу дал

            return id;
        }

        //TODO
        public int UpdateBaseProduct(BaseProductInputModel product)
        {
            int id = 0;//обращаемся к методу дал

            return id;
        }

        //TODO
        public void DeleteBaseProduct(int id)
        {
            //обращаемся к методу дал
        }
    }
}
