namespace InlämningsUppgiftAPI.Models
{
    public class ProductModel
    {
        public ProductModel()
        {

        }

        public ProductModel(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public ProductModel(int id, string name, string description, int price, string categoryName)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CategoryName = categoryName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string CategoryName { get; set; }
    }
}
