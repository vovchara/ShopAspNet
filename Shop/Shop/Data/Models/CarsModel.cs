namespace Shop.Data.Models
{
    public class CarsModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string ShortDesc { set; get; }
        public string LongDesc { set; get; }
        public string Img { set; get; }
        public ushort Price { set; get; }
        public bool IsFavourite { set; get; }
        public bool Available { set; get; }
        public int CategoryID { set; get; }
        public virtual CategoryModel Category { set; get; }
    }
}
