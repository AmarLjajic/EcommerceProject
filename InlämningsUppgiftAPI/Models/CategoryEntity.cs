using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InlämningsUppgiftAPI.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class CategoryEntity
    {
        public CategoryEntity()
        {

        }

        public CategoryEntity(ICollection<ProductEntity> products)
        {
            Products = products;
        }

        public CategoryEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public CategoryEntity(int id, string name, ICollection<ProductEntity> products)
        {
            Id = id;
            Name = name;
            Products = products;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<ProductEntity> Products { get; }
    }
}