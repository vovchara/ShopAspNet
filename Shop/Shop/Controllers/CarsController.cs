using Microsoft.AspNetCore.Mvc;
using Shop.Data.Providers;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsProvider carsProvider;
        private readonly ICategoryProvider categoryProvider;

        public CarsController(ICarsProvider carsProvider, ICategoryProvider categoryProvider)
        {
            this.carsProvider = carsProvider;
            this.categoryProvider = categoryProvider;
        }

        public ViewResult List()
        {
            var cars = carsProvider.AllCars;
            return View(cars);
        }
    }
}
