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

        [DisplayName("Mã Bình luận")]
        [Required(ErrorMessage = "Phải nhập Mã bình luận!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

        public long NewId { get; set; }

        public long AccountId { get; set; }

        [DisplayName("Nội dung")]
        [Required(ErrorMessage = "Phải nhập Nội dung bình luận!")]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual Account Account { get; set; }

        public virtual News News { get; set; }
    }
}
