namespace H2TShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Code { get; set; }

        public long NewId { get; set; }

        public long AccountId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual Account Account { get; set; }

        public virtual News News { get; set; }
    }
}
