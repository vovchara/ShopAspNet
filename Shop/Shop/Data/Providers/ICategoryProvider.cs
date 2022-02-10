using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Providers
{
    public interface ICategoryProvider
    {
        IEnumerable<CategoryModel> GetAllCategories();
    }
}
