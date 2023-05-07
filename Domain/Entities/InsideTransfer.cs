using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class InsideTransfer
    {
        /// <summary>
        /// The unique identifier for the inside transfer.
        /// </summary>
        [Key]
        public Guid InsideTransferId { get; set; }

        /// <summary>
        /// The foreign key to the inside transfer's Commodity.
        /// </summary>
        [Required]
        public Guid CommodityId { get; set; }
        /// <summary>
        /// The inside transfer's Commodity.
        /// </summary>
        [ForeignKey(nameof(CommodityId))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// The foreign key to the inside transfer's source inventory.
        /// </summary>
        [Required]
        public Guid SourceInventoryId { get; set; }
        /// <summary>
        /// The source inventory for the inside transfer.
        /// </summary>
        [ForeignKey(nameof(SourceInventoryId))]
        public virtual Inventory SourceInventory { get; set; }

        /// <summary>
        /// The foreign key to the inside transfer's destination inventory.
        /// </summary>
        [Required]
        public Guid DestinationInventoryId { get; set; }
        /// <summary>
        /// The destination inventory for the inside transfer.
        /// </summary>
        [ForeignKey(nameof(DestinationInventoryId))]
        public virtual Inventory DestinationInventory { get; set; }

        /// <summary>
        /// The total quantity of the inside transfer.
        /// </summary>
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The date of the inside transfer.
        /// </summary>
        public DateTime TransferDate { get; set; }
    }
}
