using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Providers
{
    public interface ICarsProvider
    {
        IEnumerable<CarsModel> AllCars { get; }
        IEnumerable<CarsModel> GetFavCars { get; set; }
        CarsModel GetCar(int carId);
    }
}
