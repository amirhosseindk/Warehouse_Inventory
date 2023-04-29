using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MadeInCountry
    {
        /// <summary>
        /// The unique identifier for the made in country.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the country where the product is made.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The products made in this country.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
