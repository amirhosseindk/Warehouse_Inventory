using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class InsideTransferItemList
    {
        /// <summary>
        /// The unique identifier for the InsideTransfer item list.
        /// </summary>
        [Key]
        public Guid InsideTransferItemListId { get; set; }

        /// <summary>
        /// The foreign key to the InventoryReceipt.
        /// </summary>
        [Required]
        public Guid InsideTransferId { get; set; }
        /// <summary>
        /// The InventoryReceipt associated.
        /// </summary>
        [ForeignKey(nameof(InsideTransferId))]
        public virtual InsideTransfer InsideTransfer { get; set; }
    }
}
