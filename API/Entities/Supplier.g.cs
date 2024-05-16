using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Inventory_Logistics.Entities
{
    /// <summary> 
    /// Represents a supplier entity with essential details
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// TenantId of the Supplier 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Supplier 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Supplier 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Supplier 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// ContactName of the Supplier 
        /// </summary>
        public string? ContactName { get; set; }
        /// <summary>
        /// Email of the Supplier 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Phone of the Supplier 
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Address of the Supplier 
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// Description of the Supplier 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedOn of the Supplier 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Supplier 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Supplier 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Supplier 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}