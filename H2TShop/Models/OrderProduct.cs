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

        [DisplayName("Mã order")]
        [Required(ErrorMessage = "Phải nhập Mã order!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

		[Display(Name = "Ngày đặt")]
        public DateTime OrderDate { get; set; }

        public long AccountId { get; set; }

		[Display(Name = "Tổng tiền")]
        public decimal Total { get; set; }

        [DisplayName("Phương thức vận chuyển")]
        [Required(ErrorMessage = "Phải chọn Phương thức vận chuyển!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string TransformMethod { get; set; }

        public long StatusId { get; set; }

		[Display(Name = "Thời gian tạo mới")]
        public DateTime CreatedAt { get; set; }

		[Display(Name = "Thời gian cập nhật")]
        public DateTime UpdatedAt { get; set; }

		[Display(Name = "Thời gian xóa")]
        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProductContent> OrderProductContents { get; set; }
    }
}
