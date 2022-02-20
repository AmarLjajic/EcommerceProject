using System.ComponentModel.DataAnnotations;

namespace InlämningsUppgiftAPI.Models
{
    public class ProductEntity
    {
        public ProductEntity(string name, string description, int price, int categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        public ProductEntity(int id, string name, string description, int price, int categoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }


        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}
