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
        public int Id { get; set; }

        /// <summary>
        /// The foreign key to the inventory requisition's product.
        /// </summary>
        [Required]
        public int ProductId { get; set; }
        /// <summary>
        /// The inventory requisition's product.
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        /// <summary>
        /// The foreign key to the consumer product.
        /// </summary>
        [Required]
        public int ConsumerID { get; set; }
        /// <summary>
        /// The inventory requisition's consyner.
        /// </summary>
        [ForeignKey(nameof(ConsumerID))]
        public virtual Consumer Consumer { get; set; }


        /// <summary>
        /// The foreign key to the inventory requisition's warehouse.
        /// </summary>
        [Required]
        public int InventoryId { get; set; }
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

        public decimal ProductTotalPrice
        {
            get
            {
                return Product.UnitPrice * TotalQuantity;
            }
        }

        public static decimal AllProductsTotalPrice(IEnumerable<InventoryRequisition> requisitions)
        {
            return requisitions.Sum(r => r.ProductTotalPrice);
        }
    }
}
