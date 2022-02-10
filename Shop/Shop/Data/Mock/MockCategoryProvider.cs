using Shop.Data.Models;
using Shop.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mock
{
    public class MockCategoryProvider : ICategoryProvider
    {
        public IEnumerable<CategoryModel> GetAllCategories()
        {
            var result = new List<CategoryModel>();
            result.Add(new CategoryModel { CategoryName = "Elector cars", Description = "Drive the future" });
            result.Add(new CategoryModel { CategoryName = "Classic cars", Description = "Cars with fuel driven engine" });
            return result;
        }
    }
}
