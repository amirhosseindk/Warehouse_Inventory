using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Warehouse
    {
        /// <summary>
        /// The unique identifier for the warehouse.
        /// </summary>
        [Key]
        public Guid WarehouseId { get; set; }

        /// <summary>
        /// The name of the warehouse.
        /// </summary>
        [Required]
        public string WarehouseName { get; set; }

        /// <summary>
        /// The Location of the warehouse.
        /// </summary>
        [Required]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// The inventory items stored in this warehouse.
        /// </summary>
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
