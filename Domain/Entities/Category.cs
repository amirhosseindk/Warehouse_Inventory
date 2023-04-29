using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Category
    {
        /// <summary>
        /// The unique identifier for the category.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The products in this category.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
