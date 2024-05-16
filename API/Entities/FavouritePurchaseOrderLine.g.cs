using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Inventory_Logistics.Entities
{
    /// <summary> 
    /// Represents a favouritepurchaseorderline entity with essential details
    /// </summary>
    public class FavouritePurchaseOrderLine
    {
        /// <summary>
        /// Primary key for the FavouritePurchaseOrderLine 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Required field TenantId of the FavouritePurchaseOrderLine 
        /// </summary>
        [Required]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Foreign key referencing the Product to which the FavouritePurchaseOrderLine belongs 
        /// </summary>
        [Required]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// Required field UserId of the FavouritePurchaseOrderLine 
        /// </summary>
        [Required]
        public Guid UserId { get; set; }
    }
}