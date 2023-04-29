using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Product
    {
        /// <summary>
        /// The unique identifier for the product.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        [Column(TypeName = "decimal(19,4)")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The Quantity of the product.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// The foreign key to the product's category.
        /// </summary>
        [Required]
        public int CategoryId { get; set; }
        /// <summary>
        /// The product's category.
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        /// <summary>
        /// The foreign key to the product's supplier.
        /// </summary>
        [Required]
        public int SupplierId { get; set; }
        /// <summary>
        /// The product's supplier.
        /// </summary>
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// The foreign key to the product's made in country.
        /// </summary>
        [Required]
        public int MadeInCountryCountryId { get; set; }
        /// <summary>
        /// The country where the product is made.
        /// </summary>
        [ForeignKey(nameof(MadeInCountryCountryId))]
        public virtual MadeInCountry MadeInCountry { get; set; }

        /// <summary>
        /// The foreign key to the product's unit measure.
        /// </summary>
        [Required]
        public int UnitMeasureId { get; set; }
        /// <summary>
        /// The product's unit of measurement.
        /// </summary>
        [ForeignKey(nameof(UnitMeasureId))]
        public virtual UnitMeasure UnitMeasure { get; set; }
    }
}
