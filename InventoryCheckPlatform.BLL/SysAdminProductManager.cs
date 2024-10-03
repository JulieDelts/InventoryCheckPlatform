using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
    public class SysAdminProductManager
    {
        //TODO
        public List<BasePoductOutputModel> GetAllBaseProducts()
        {
            return new List<BasePoductOutputModel>
            {
                new BasePoductOutputModel()
                {
                    Id= 1,
                    Name="банан",
                    Category = "фрукт"

                },
                new BasePoductOutputModel()
                {
                    Id=2,
                    Name="картошечка",
                    Category = "овощ"
                },
                new BasePoductOutputModel()
                {
                    Id=3,
                    Name="шампиньончик",
                    Category = "грибочек"
                },
                  new BasePoductOutputModel()
                {
                    Id=4,
                    Name="молоко",
                    Category = "молочные"
                },
                new BasePoductOutputModel()
                {
                    Id=5,
                    Name="сырочек",
                    Category = "молочные"
                },
                new BasePoductOutputModel()
                {
                    Id=6,
                    Name="хлебушке",
                    Category = "мучное"
                },
                new BasePoductOutputModel()
                {
                    Id=7,
                    Name="ананасик",
                    Category = "фрукт"
                },
                new BasePoductOutputModel()
                {
                    Id=8,
                    Name="лосось",
                    Category = "рыбное"
                },
                new BasePoductOutputModel()
                {
                    Id=9,
                    Name="говядина",
                    Category = "мясное"
                },
                new BasePoductOutputModel()
                {
                    Id=10,
                    Name="джин",
                    Category = "алкоголь"
                }
            };
        }

        //TODO
        public BasePoductOutputModel GetBaseProductById(int id)
        {
            return new BasePoductOutputModel()
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
