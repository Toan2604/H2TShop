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
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long OrderProductId { get; set; }

        public long UnitOfMeasureId { get; set; }

        public long Quantity { get; set; }

        public decimal? Price { get; set; }

        public decimal? Amount { get; set; }

        public virtual OrderProduct OrderProduct { get; set; }

        public virtual Product Product { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
