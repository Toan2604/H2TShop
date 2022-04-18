namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProductContent")]
    public partial class OrderProductContent
    {
        [Key]
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long OrderProductId { get; set; }

        public long UnitOfMeasureId { get; set; }

		[Display(Name = "S? l??ng")]
        public long Quantity { get; set; }

		[Display(Name = "??n gi�")]
        public decimal? Price { get; set; }

		[Display(Name = "Th�nh ti?n")]
        public decimal? Amount { get; set; }

        public virtual OrderProduct OrderProduct { get; set; }

        public virtual Product Product { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
