namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("Mã nhà cung c?p")]
        [Required(ErrorMessage = "Ph?i nh?p Mã nhà cung c?p!")]
        [StringLength(500, ErrorMessage = "?? dài không v??t quá 500 ký t?!")]
        public string Code { get; set; }

        [DisplayName("Tên nhà cung c?p")]
        [Required(ErrorMessage = "Ph?i nh?p Tên nhà cung c?p!")]
        [StringLength(3000, ErrorMessage = "?? dài không v??t quá 3000 ký t?!")]
        public string Name { get; set; }

        [DisplayName("??a ch?")]
        [Required(ErrorMessage = "Ph?i nh?p ??a ch?!")]
        [StringLength(3000, ErrorMessage = "?? dài không v??t quá 3000 ký t?!")]
        public string Address { get; set; }

        [DisplayName("S? ?i?n tho?i")]
        [Required(ErrorMessage = "Ph?i nh?p S? ?i?n tho?i!")]
        [Phone(ErrorMessage = "Sai ??nh d?ng S? ?i?n tho?i!")]
        [StringLength(500, ErrorMessage = "?? dài không v??t quá 500 ký t?!")]
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
