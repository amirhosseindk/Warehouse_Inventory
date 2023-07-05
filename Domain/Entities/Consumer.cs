using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Consumer : BaseEntity
    {
        /// <summary>
        /// The name of the Consumer.
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The lastname of the Consumer.
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// The email of the Consumer.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// The number of the Consumer.
        /// </summary>
        [Required]
        public string Phone { get; set; }
        /// <summary>
        /// The Address of the Consumer.
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// The Description of the Consumer.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// The Commodities consumed by this Consumer.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
