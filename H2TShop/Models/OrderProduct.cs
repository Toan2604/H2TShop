namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
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

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("M� order")]
        [Required(ErrorMessage = "Ph?i nh?p M� order!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Code { get; set; }

		[Display(Name = "Ng�y ??t")]
        public DateTime OrderDate { get; set; }

        public long AccountId { get; set; }

		[Display(Name = "T?ng ti?n")]
        public decimal Total { get; set; }

        [DisplayName("Ph??ng th?c v?n chuy?n")]
        [Required(ErrorMessage = "Ph?i ch?n Ph??ng th?c v?n chuy?n!")]
        [StringLength(3000, ErrorMessage = "?? d�i kh�ng v??t qu� 3000 k� t?!")]
        public string TransformMethod { get; set; }

        public long StatusId { get; set; }

		[Display(Name = "Th?i gian t?o m?i")]
        public DateTime CreatedAt { get; set; }

		[Display(Name = "Th?i gian c?p nh?t")]
        public DateTime UpdatedAt { get; set; }

		[Display(Name = "Th?i gian x�a")]
        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProductContent> OrderProductContents { get; set; }
    }
}
