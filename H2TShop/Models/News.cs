namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            Comments = new HashSet<Comment>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("Mã tin tức")]
        [Required(ErrorMessage = "Phải nhập Mã tin tức!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

        [DisplayName("Tên tin tức")]
        [Required(ErrorMessage = "Phải nhập Tên tin tức!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string Name { get; set; }

        [DisplayName("Nội dung tin tức")]
        [Required(ErrorMessage = "Phải nhập Nội dung tin tức!")]
        public string Content { get; set; }

        [DisplayName("Tiêu đề tin tức")]
        [Required(ErrorMessage = "Phải nhập Tiêu đề tin tức!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string Title { get; set; }

        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
