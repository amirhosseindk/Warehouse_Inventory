using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UnitMeasure
    {
        /// <summary>
        /// The unique identifier for the unit of measurement.
        /// </summary>
        [Key]
        public Guid UnitMeasureId { get; set; }

        /// <summary>
        /// The name of the unit of measurement.
        /// </summary>
        [Required]
        public string UnitMeasureName { get; set; }

        /// <summary>
        /// The Commodities using this unit of measurement.
        /// </summary>
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
