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

        [DisplayName("Mã loại")]
        [Required(ErrorMessage = "Phải nhập Mã loại!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

        [DisplayName("Tên loại")]
        [Required(ErrorMessage = "Phải nhập Tên loại!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string Name { get; set; }

        public long StatusId { get; set; }

        [DisplayName("Hình ảnh")]
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
