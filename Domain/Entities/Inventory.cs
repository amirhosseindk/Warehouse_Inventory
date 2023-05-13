using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Inventory : BaseEntity
    {
        /// <summary>
        /// The unique identifier for the inventory item.
        /// </summary>
        [Key]
        public Guid InventoryId { get; set; }

        /// <summary>
        /// The foreign key to the inventory item's warehouse.
        /// </summary>
        [Required]
        public Guid WarehouseId { get; set; }
        /// <summary>
        /// The warehouse where the inventory item is stored.
        /// </summary>
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse Warehouse { get; set; }

        /// <summary>
        /// The list of items in the inventory.
        /// </summary>
        public virtual ICollection<InventoryItemList> Items { get; set; }

        /// <summary>
        /// The quantity of the inventory item.
        /// </summary>
        public int TotalQuantity { get; set; }
    }
}
