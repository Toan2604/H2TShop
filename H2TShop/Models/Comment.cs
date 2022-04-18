namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("M� B�nh lu?n")]
        [Required(ErrorMessage = "Ph?i nh?p M� b�nh lu?n!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Code { get; set; }

        public long NewId { get; set; }

        public long AccountId { get; set; }

        [DisplayName("N?i dung")]
        [Required(ErrorMessage = "Ph?i nh?p N?i dung b�nh lu?n!")]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual Account Account { get; set; }

        public virtual News News { get; set; }
    }
}
