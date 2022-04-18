/*namespace H2TShop.Models
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

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("M� ng??i d�ng")]
        public long Code { get; set; }

        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        [Required(ErrorMessage = "Ph?i nh?p H? v� t�n!")]
        [DisplayName("H? v� t�n")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ph?i ch?n Gi?i t�nh!")]
        [DisplayName("H? v� t�n")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Gender { get; set; }

		[Display(Name = "Ng�y sinh")]
        public DateTime Dob { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Ph?i nh?p Email!")]
		[EmailAddress(ErrorMessage = "Sai ??nh d?ng Email!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Email { get; set; }

        [DisplayName("S? ?i?n tho?i")]
        [Required(ErrorMessage = "Ph?i nh?p S? ?i?n tho?i!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Ph?i nh?p ??a ch?!")]
		[Phone(ErrorMessage = "Sai ??nh d?ng s? ?i?n tho?i!")]
        [DisplayName("??a ch?")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Address { get; set; }

        [DisplayName("T�n ??ng nh?p")]
        [Required(ErrorMessage = "Ph?i nh?p T�n ??ng nh?p!")]
        [StringLength(500, MinimumLength =4 , ErrorMessage = "T�n ??ng nh?p ph?i d�i t? 4 k� t? tr? l�n!")]
        public string UserName { get; set; }

        [DisplayName("M?t nh?p")]
        [Required(ErrorMessage = "Ph?i nh?p M?t kh?u!")]
        [StringLength(500, MinimumLength = 8, ErrorMessage = "M?t kh?u ph?i c� �t nh?t 8 k� t?!")]
        public string Password { get; set; }

        public string Token { get; set; }

        public string Image { get; set; }

        [DisplayName("Ph�n quy?n")]
        [Required(ErrorMessage = "Ph?i ch?n Ph�n quy?n!")]
        [StringLength(500, ErrorMessage = "?? d�i kh�ng v??t qu� 500 k� t?!")]
        public string Role { get; set; }

        public long StatusId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime Updated { get; set; }

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
*/