
using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
    public class LogisticianProductManager
    {
        //TODO
        public List<SpecificProductOutputModel> GetAllSpecificProducts()
        {
            return new List<SpecificProductOutputModel>
            {
                new SpecificProductOutputModel()
                {
                    Id= 1,
                    Name="банан",
                    Category = "фрукт",
                    Vendor = "Макака",
                    Price = 25
                },
                new SpecificProductOutputModel()
                {
                    Id=2,
                    Name="картошечка",
                    Category = "овощ",
                    Vendor = "Лукаш",
                    Price = 7
                },
                new SpecificProductOutputModel()
                {
                    Id=3,
                    Name="шампиньончик",
                    Category = "грибочек",
                    Vendor = "Лесочек",
                    Price = 5
                },
                  new SpecificProductOutputModel()
                {
                    Id=4,
                    Name="молоко",
                    Category = "молочные",
                    Vendor = "Коровка веселая",
                    Price = 70
                },
                new SpecificProductOutputModel()
                {
                    Id=5,
                    Name="сырочек",
                    Category = "молочные",
                    Vendor = "Бобик",
                    Price = 38
                },
                new SpecificProductOutputModel()
                {
                    Id=6,
                    Name="хлебушке",
                    Category = "мучное",
                    Vendor = "Крестьяне уставшие",
                    Price = 40,
                },
                new SpecificProductOutputModel()
                {
                    Id=7,
                    Name="ананасик",
                    Category = "фрукт",
                    Vendor = "Барбос",
                    Price = 120,
                },
                new SpecificProductOutputModel()
                {
                    Id=8,
                    Name="лосось",
                    Category = "рыбное",
                    Vendor = "Ктулху",
                    Price = 200,
                },
                new SpecificProductOutputModel()
                {
                    Id=9,
                    Name="говядина",
                    Category = "мясное",
                    Vendor = "Ваша жопа",
                    Price = 300
                },
                new SpecificProductOutputModel()
                {
                    Id=10,
                    Name="джин",
                    Category = "алкоголь",
                    Vendor = "ОАО Помощь депрессивным",
                    Price = 500
                }
            };
        }

        //TODO
        public SpecificProductOutputModel GetSpecificProductById(int id)
        {
            return new SpecificProductOutputModel()
            {
                Id = id,
                Name = "джин",
                Category = "алкоголь",
                Vendor = "ОАО Помощь депрессивным",
                Price = 500
            };
        }

        //TODO
        public int AddNewSpecificProduct(SpecificProductInputModel product)
        {
            int id = 0;//обращаемся к методу дал

            return id;
        }

        //TODO
        public int UpdateSpecificProduct(SpecificProductInputModel product)
        {
            int id = 0;//обращаемся к методу дал

            return id;
        }

        //TODO
        public void DeleteSpecificProduct(int id)
        {
            //обращаемся к методу дал
        }
    }
}
