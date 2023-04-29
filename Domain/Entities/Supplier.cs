using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Supplier
    {
        /// <summary>
        /// The unique identifier for the supplier.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The name of the supplier.
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The email of the supplier.
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// The number of the supplier.
        /// </summary>
        [Required]
        public string Phone { get; set; }
        /// <summary>
        /// The products supplied by this supplier.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }

}
