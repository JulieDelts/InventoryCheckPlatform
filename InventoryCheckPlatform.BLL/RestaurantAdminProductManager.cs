﻿using InventoryCheckPlatform.Core.InputModels;
using InventoryCheckPlatform.Core.OutputModels;

namespace InventoryCheckPlatform.BLL
{
    public class RestaurantAdminProductManager
    {
        //TODO
        public List<SpecificProductOutputModelWithAmount> GetAllSpecificProductsWithAmount()
        {
            return new List<SpecificProductOutputModelWithAmount>
            {
                new SpecificProductOutputModelWithAmount()
                {
                    Id= 1,
                    Name="банан",
                    Category = "фрукт",
                    Vendor = "Макака",
                    Price = 25,
                    Amount = 30
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=2,
                    Name="картошечка",
                    Category = "овощ",
                    Vendor = "Лукаш",
                    Price = 7,
                    Amount = 500
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=3,
                    Name="шампиньончик",
                    Category = "грибочек",
                    Vendor = "Лесочек",
                    Price = 5,
                    Amount = 47

                },
                  new SpecificProductOutputModelWithAmount()
                {
                    Id=4,
                    Name="молоко",
                    Category = "молочные",
                    Vendor = "Коровка веселая",
                    Price = 70,
                    Amount = 39
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=5,
                    Name="сырочек",
                    Category = "молочные",
                    Vendor = "Бобик",
                    Price = 38,
                    Amount = 48
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=6,
                    Name="хлебушке",
                    Category = "мучное",
                    Vendor = "Крестьяне уставшие",
                    Price = 40,
                    Amount = 56
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=7,
                    Name="ананасик",
                    Category = "фрукт",
                    Vendor = "Барбос",
                    Price = 120,
                    Amount = 20
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=8,
                    Name="лосось",
                    Category = "рыбное",
                    Vendor = "Ктулху",
                    Price = 200,
                    Amount = 74
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=9,
                    Name="говядина",
                    Category = "мясное",
                    Vendor = "Ваша жопа",
                    Price = 300,
                    Amount = 23
                },
                new SpecificProductOutputModelWithAmount()
                {
                    Id=10,
                    Name="джин",
                    Category = "алкоголь",
                    Vendor = "ОАО Помощь депрессивным",
                    Price = 500,
                    Amount = 29
                }
            };
        }

        //TODO
        public SpecificProductOutputModelWithAmount GetSpecificProductById(int id)
        {
            return new SpecificProductOutputModelWithAmount()
            {
                Id = id,
                Name = "джин",
                Category = "алкоголь",
                Vendor = "ОАО Помощь депрессивным",
                Price = 500,
                Amount = 29
            };
        }

        //TODO
        public int AddNewSpecificProduct(ExtendedSpecificProductInputModelWithAmount product)
        {
            int id = 0;//обращаемся к методу дал

            return id;
        }

        //TODO
        public int UpdateSpecificProduct(ExtendedSpecificProductInputModelWithAmount product)
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
