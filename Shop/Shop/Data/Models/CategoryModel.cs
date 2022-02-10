using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<CarsModel> Cars { get; set; }
    }
}
