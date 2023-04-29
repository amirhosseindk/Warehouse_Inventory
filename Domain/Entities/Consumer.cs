using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Consumer
    {
        /// <summary>
        /// The unique identifier for the Consumer.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The name of the Consumer.
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The email of the Consumer.
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// The number of the Consumer.
        /// </summary>
        [Required]
        public string Phone { get; set; }
        /// <summary>
        /// The products consumed by this Consumer.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }

}
