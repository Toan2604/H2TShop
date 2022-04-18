namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderProduct()
        {
            OrderProductContents = new HashSet<OrderProductContent>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Code { get; set; }

        public DateTime OrderDate { get; set; }

        public long AccountId { get; set; }

        public decimal Total { get; set; }

        [Required]
        [StringLength(3000)]
        public string TransformMethod { get; set; }

        public long StatusId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProductContent> OrderProductContents { get; set; }
    }
}
