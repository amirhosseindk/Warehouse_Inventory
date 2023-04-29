using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UnitMeasure
    {
        /// <summary>
        /// The unique identifier for the unit of measurement.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the unit of measurement.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The products using this unit of measurement.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
