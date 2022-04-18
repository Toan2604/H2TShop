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

        [DisplayName("Mã nhà cung cấp")]
        [Required(ErrorMessage = "Phải nhập Mã nhà cung cấp!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

        [DisplayName("Tên nhà cung cấp")]
        [Required(ErrorMessage = "Phải nhập Tên nhà cung cấp!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string Name { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Phải nhập Địa chỉ!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string Address { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Phải nhập Số điện thoại!")]
        [Phone(ErrorMessage = "Sai định dạng Số điện thoại!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
