using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Inventory
    {
        /// <summary>
        /// The unique identifier for the inventory item.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The foreign key to the inventory item's product.
        /// </summary>
        [Required]
        public int ProductId { get; set; }
        /// <summary>
        /// The inventory item's product.
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        /// <summary>
        /// The foreign key to the inventory item's warehouse.
        /// </summary>
        [Required]
        public int WarehouseId { get; set; }
        /// <summary>
        /// The warehouse where the inventory item is stored.
        /// </summary>
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse Warehouse { get; set; }

        /// <summary>
        /// The quantity of the inventory item.
        /// </summary>
        public int Quantity { get; set; }
    }
}
