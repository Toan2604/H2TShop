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

        [DisplayName("Mã tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p Mã tin t?c!")]
        [StringLength(500, ErrorMessage = "?? dài không v??t quá 500 ký t?!")]
        public string Code { get; set; }

        [DisplayName("Tên tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p Tên tin t?c!")]
        [StringLength(3000, ErrorMessage = "?? dài không v??t quá 3000 ký t?!")]
        public string Name { get; set; }

        [DisplayName("N?i dung tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p N?i dung tin t?c!")]
        public string Content { get; set; }

        [DisplayName("Tiêu ?? tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p Tiêu ?? tin t?c!")]
        [StringLength(3000, ErrorMessage = "?? dài không v??t quá 3000 ký t?!")]
        public string Title { get; set; }

        [DisplayName("Hình ?nh")]
        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
