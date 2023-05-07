using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class SupplierInvoice
    {
        /// <summary>
        /// The unique identifier for the SupplierInvoice.
        /// </summary>
        [Key]
        public Guid SupplierInvoiceId { get; set; }

        /// <summary>
        /// The list of items in the Receipt.
        /// </summary>
        public virtual ICollection<ReceiptItemList> ReceiptItems { get; set; }

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
        public DateTime ReceiptDate { get; set; }
    }
}
