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

        [DisplayName("M� tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p M� tin t?c!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Code { get; set; }

        [DisplayName("T�n tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p T�n tin t?c!")]
        [StringLength(3000, ErrorMessage = "?? d�i kh�ng v??t qu� 3000 k� t?!")]
        public string Name { get; set; }

        [DisplayName("N?i dung tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p N?i dung tin t?c!")]
        public string Content { get; set; }

        [DisplayName("Ti�u ?? tin t?c")]
        [Required(ErrorMessage = "Ph?i nh?p Ti�u ?? tin t?c!")]
        [StringLength(3000, ErrorMessage = "?? d�i kh�ng v??t qu� 3000 k� t?!")]
        public string Title { get; set; }

        [DisplayName("H�nh ?nh")]
        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
