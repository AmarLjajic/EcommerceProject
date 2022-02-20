namespace InlämningsUppgiftAPI.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {

        }

        public CategoryModel(string name, string product)
        {
            Name = name;
            Product = product;
        }

        public CategoryModel(int id, string name, string product)
        {
            Id = id;
            Name = name;
            Product = product;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Product { get; set; }

    }
}
