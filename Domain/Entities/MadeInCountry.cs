using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MadeInCountry : BaseEntity
    {
        /// <summary>
        /// The unique identifier for the made in country.
        /// </summary>
        [Key]
        public Guid MadeInCountryId { get; set; }

        /// <summary>
        /// The name of the country where the product is made.
        /// </summary>
        [Required]
        public string MadeInCountryName { get; set; }

        /// <summary>
        /// The products made in this country.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
