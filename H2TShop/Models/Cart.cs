namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cart()
        {
            ProductCartMappings = new HashSet<ProductCartMapping>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("M� Kh�ch h�ng")]
        public long CustomerId { get; set; }

        [DisplayName("T?ng s? l??ng")]
        public long TotalQuantity { get; set; }

        [DisplayName("Ghi ch�")]
        public string Note { get; set; }

        [DisplayName("T?ng ti?n")]
        public decimal TotalPrice { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCartMapping> ProductCartMappings { get; set; }
    }
}
