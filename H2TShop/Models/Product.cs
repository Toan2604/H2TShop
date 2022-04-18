namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProductContents = new HashSet<OrderProductContent>();
            ProductCartMappings = new HashSet<ProductCartMapping>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Code { get; set; }

        [Required]
        [StringLength(3000)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public long StatusId { get; set; }

        public long UnitOfMeasureId { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Quantity { get; set; }

        public long Count { get; set; }

        public string Image { get; set; }

        public string Size { get; set; }

        public long CategoryId { get; set; }

        public long BuyerStoreId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProductContent> OrderProductContents { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Status Status { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCartMapping> ProductCartMappings { get; set; }
    }
}
