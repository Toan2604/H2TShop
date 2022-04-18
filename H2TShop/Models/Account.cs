namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Carts = new HashSet<Cart>();
            Comments = new HashSet<Comment>();
            OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("Mã người dùng")]
        [Required(ErrorMessage = "Phải nhập Mã người dùng!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Phải nhập Họ và tên!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Phải chọn Giới tính!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Gender { get; set; }

		[Display(Name = "Ngày sinh")]
        public DateTime Dob { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Phải nhập Email!")]
        [EmailAddress(ErrorMessage = "Sai định dạng Email!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Email { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Phải nhập Số điện thoại!")]
        [Phone(ErrorMessage = "Sai định dạng Số điện thoại!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Phone { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Phải nhập Địa chỉ!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Address { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Phải nhập Tên đăng nhập!")]
        [StringLength(500, MinimumLength = 4, ErrorMessage = "Tên đăng nhập phải dài từ 4 ký tự trở lên!")]
        public string UserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Phải nhập Mật khẩu!")]
        [StringLength(500, MinimumLength = 8, ErrorMessage = "Mật khẩu phảii có ít nhấtt 8 ký tự!")]
        public string Password { get; set; }

        public string Token { get; set; }

        public string Image { get; set; }

        [DisplayName("Phân quyền")]
        [Required(ErrorMessage = "Phải chọn Phân quyền!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Role { get; set; }

        public long StatusId { get; set; }

        [DisplayName("Thời gian tạo mới")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Thời gian cập nhật")]
        public DateTime Updated { get; set; }

        [DisplayName("Thời gian xóa")]
        public DateTime? DeletedAt { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
