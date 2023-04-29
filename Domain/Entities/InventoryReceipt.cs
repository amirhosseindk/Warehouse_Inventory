﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class InventoryReceipt
    {
        /// <summary>
        /// The unique identifier for the inventory receipt.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The foreign key to the inventory receipt's product.
        /// </summary>
        [Required]
        public int ProductId { get; set; }
        /// <summary>
        /// The inventory receipt's product.
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        /// <summary>
        /// The foreign key to the inventory receipt's warehouse.
        /// </summary>
        [Required]
        public int InventoryId { get; set; }
        /// <summary>
        /// The warehouse for the inventory receipt.
        /// </summary>
        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }

        /// <summary>
        /// The foreign key to the inventory receipt's supplier.
        /// </summary>
        [Required]
        public int SupplierId { get; set; }
        /// <summary>
        /// The supplier for the inventory receipt.
        /// </summary>
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier Supplier { get; set; }

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

        public decimal ProductTotalPrice
        {
            get
            {
                return Product.UnitPrice * TotalQuantity;
            }
        }

        public static decimal AllProductsTotalPrice(IEnumerable<InventoryReceipt> receipts)
        {
            return receipts.Sum(r => r.ProductTotalPrice);
        }
    }
}
