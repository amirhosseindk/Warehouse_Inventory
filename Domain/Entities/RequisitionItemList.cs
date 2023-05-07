using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class RequisitionItemList : MovementItemList
    {
        /// <summary>
        /// The unique identifier for the Requisition item list.
        /// </summary>
        [Key]
        public Guid RequisitionItemListId { get; set; }

        /// <summary>
        /// The foreign key to the InventoryRequisition.
        /// </summary>
        [Required]
        public Guid InventoryRequisitionId { get; set; }
        /// <summary>
        /// The InventoryRequisition associated.
        /// </summary>
        [ForeignKey(nameof(InventoryRequisitionId))]
        public virtual InventoryRequisition InventoryRequisition { get; set; }
    }
}
