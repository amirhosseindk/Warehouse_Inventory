using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class InventoryRequisition
    {
        /// <summary>
        /// The unique identifier for the inventory requisition.
        /// </summary>
        [Key]
        public Guid InventoryRequisitionId { get; set; }

        /// <summary>
        /// The foreign key to the inventory requisition's Commodity.
        /// </summary>
        [Required]
        public Guid CommodityId { get; set; }
        /// <summary>
        /// The inventory requisition's Commodity.
        /// </summary>
        [ForeignKey(nameof(CommodityId))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// The foreign key to the consumer Commodity.
        /// </summary>
        [Required]
        public Guid ConsumerID { get; set; }
        /// <summary>
        /// The inventory requisition's consumer.
        /// </summary>
        [ForeignKey(nameof(ConsumerID))]
        public virtual Consumer Consumer { get; set; }


        /// <summary>
        /// The foreign key to the inventory requisition's warehouse.
        /// </summary>
        [Required]
        public Guid InventoryId { get; set; }
        /// <summary>
        /// The warehouse for the inventory requisition.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The total quantity of the inventory requisition.
        /// </summary>
        [Required]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The date of the inventory requisition.
        /// </summary>
        [Required]
        public DateTime RequisitionDate { get; set; }
    }
}
