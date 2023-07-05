using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Supplier : BaseEntity
    {
        /// <summary>
        /// The name of the supplier.
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The lastname of the supplier.
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// The email of the supplier.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// The number of the supplier.
        /// </summary>
        [Required]
        public string Phone { get; set; }
        /// <summary>
        /// The Address of the supplier.
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// The Description of the supplier.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// The Commodities supplied by this supplier.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }

}
