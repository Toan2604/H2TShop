namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("M� lo?i")]
        [Required(ErrorMessage = "Ph?i nh?p M� lo?i!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Code { get; set; }

        [DisplayName("T�n lo?i")]
        [Required(ErrorMessage = "Ph?i nh?p T�n lo?i!")]
        [StringLength(3000, ErrorMessage = "?? d�i kh�ng v??t qu� 3000 k� t?!")]
        public string Name { get; set; }

        public long StatusId { get; set; }

        [DisplayName("H�nh ?nh")]
        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
