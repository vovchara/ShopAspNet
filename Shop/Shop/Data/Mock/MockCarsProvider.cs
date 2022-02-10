using Shop.Data.Models;
using Shop.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mock
{
    public class MockCarsProvider : ICarsProvider
    {
        private readonly ICategoryProvider _categoryCars = new MockCategoryProvider();

        public IEnumerable<CarsModel> AllCars
        {
            get
            {
                return new List<CarsModel>
                {
                    new CarsModel { Name = "Tesla Model S",
                        ShortDesc = "Fast one",
                        LongDesc = "3 sec to 100 km h. Omg wtf",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().First()
                    },
                    new CarsModel {
                        Name = "Ford Fiesta",
                        ShortDesc = "Slow shit",
                        LongDesc = "13 sec to 100 km h. Small city car",
                        Img = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarsModel {
                        Name = "BMW M3",
                        ShortDesc = "Fast one, expensive",
                        LongDesc = "4 sec to 100 km h. Vidro bude lomatys",
                        Img = "/img/m3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarsModel {
                        Name = "Mercedes C class",
                        ShortDesc = "Pafosno",
                        LongDesc = "Majorno pafosno for misto zbs",
                        Img = "/img/mercedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarsModel {
                        Name = "Nissan Leaf",
                        ShortDesc = "Deshevo i serdyto",
                        LongDesc = "Bystro, deshevo, ale ne daleko",
                        Img = "/img/nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().First()
                    }
                };
            }
        }

        public IEnumerable<CarsModel> GetFavCars { get; set; }

        public CarsModel GetCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
