using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Category
    {
        /// <summary>
        /// The unique identifier for the category.
        /// </summary>
        [Key]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        [Required]
        public string CategoryName { get; set; }

        /// <summary>
        /// The Commodities in this category.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
