namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProductContents = new HashSet<OrderProductContent>();
            ProductCartMappings = new HashSet<ProductCartMapping>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("Mã sản phẩm")]
        [Required(ErrorMessage = "Phải nhập Mã sản phẩm!")]
        [StringLength(500, ErrorMessage = "Độ dài không vượt quá 500 ký tự!")]
        public string Code { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "Phải nhập Tên sản phẩm!")]
        [StringLength(3000, ErrorMessage = "Độ dài không vượt quá 3000 ký tự!")]
        public string Name { get; set; }

        [DisplayName("Mô tả")]
        [Required(ErrorMessage = "Phải nhập Mô tả!")]
        public string Description { get; set; }

        [DisplayName("Giá gốc")]
        public decimal Price { get; set; }

        public long StatusId { get; set; }

        public long UnitOfMeasureId { get; set; }

        [DisplayName("Giá bán")]
        public decimal SalePrice { get; set; }

        [DisplayName("Số lượng")]
        public decimal Quantity { get; set; }

        [DisplayName("Số lần đã bán")]
        public long Count { get; set; }

        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [DisplayName("Kích thước")]
        public string Size { get; set; }

        public long CategoryId { get; set; }

        public long BuyerStoreId { get; set; }

		[Display(Name = "Thời gian tạo mới")]
        public DateTime CreatedAt { get; set; }

		[Display(Name = "Thời gian cập nhật")]
        public DateTime UpdatedAt { get; set; }

		[Display(Name = "Thời gian xóa")]
        public DateTime? DeletedAt { get; set; }

        public bool Used { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProductContent> OrderProductContents { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Status Status { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCartMapping> ProductCartMappings { get; set; }
    }
}
