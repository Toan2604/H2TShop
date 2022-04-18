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

        [DisplayName("Mã s?n ph?m")]
        [Required(ErrorMessage = "Ph?i nh?p Mã s?n ph?m!")]
        [StringLength(500, ErrorMessage = "?? dài không v??t quá 500 ký t?!")]
        public string Code { get; set; }

        [DisplayName("Tên s?n ph?m")]
        [Required(ErrorMessage = "Ph?i nh?p Tên s?n ph?m!")]
        [StringLength(3000, ErrorMessage = "?? dài không v??t quá 3000 ký t?!")]
        public string Name { get; set; }

        [DisplayName("Mô t?")]
        [Required(ErrorMessage = "Ph?i nh?p Mô t?!")]
        public string Description { get; set; }

        [DisplayName("Giá g?c")]
        public decimal Price { get; set; }

        public long StatusId { get; set; }

        public long UnitOfMeasureId { get; set; }

        [DisplayName("Giá bán")]
        public decimal SalePrice { get; set; }

        [DisplayName("S? l??ng")]
        public decimal Quantity { get; set; }

        [DisplayName("S? l?n ?ã bán")]
        public long Count { get; set; }

        [DisplayName("Hình ?nh")]
        public string Image { get; set; }

        [DisplayName("Kích th??c")]
        public string Size { get; set; }

        public long CategoryId { get; set; }

        public long BuyerStoreId { get; set; }

		[Display(Name = "Th?i gian t?o m?i")]
        public DateTime CreatedAt { get; set; }

		[Display(Name = "Th?i gian c?p nh?t")]
        public DateTime UpdatedAt { get; set; }

		[Display(Name = "Th?i gian xóa")]
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
