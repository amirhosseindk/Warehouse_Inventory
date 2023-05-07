using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ConsumerInvoice
    {
        /// <summary>
        /// The unique identifier for the inventory requisition.
        /// </summary>
        [Key]
        public Guid ConsumerInvoiceId { get; set; }

        /// <summary>
        /// The list of items in the Requisition.
        /// </summary>
        public virtual ICollection<RequisitionItemList> RequisitionItems { get; set; }

        /// <summary>
        /// The foreign key to the inventory receipt's warehouse.
        /// </summary>
        [Required]
        public Guid WarehouseId { get; set; }
        /// <summary>
        /// The warehouse for the inventory receipt.
        /// </summary>
        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse Warehouse { get; set; }

        /// <summary>
        /// The total quantity of the inventory receipt.
        /// </summary>
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The total price of the inventory receipt.
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// The date of the inventory receipt.
        /// </summary>
        public DateTime RequisitiontDate { get; set; }
    }
}
