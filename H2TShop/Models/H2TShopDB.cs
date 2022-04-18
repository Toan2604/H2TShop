using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace H2TShop.Models
{
	public partial class H2TShopDB : DbContext
	{
		public H2TShopDB()
			: base("name=H2TShopDB")
		{
		}

		public virtual DbSet<Account> Accounts { get; set; }
		public virtual DbSet<Cart> Carts { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Comment> Comments { get; set; }
		public virtual DbSet<News> News { get; set; }
		public virtual DbSet<OrderProduct> OrderProducts { get; set; }
		public virtual DbSet<OrderProductContent> OrderProductContents { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Status> Status { get; set; }
		public virtual DbSet<Supplier> Suppliers { get; set; }
		public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
		public virtual DbSet<ProductCartMapping> ProductCartMappings { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Account>()
				.HasMany(e => e.Carts)
				.WithRequired(e => e.Account)
				.HasForeignKey(e => e.CustomerId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Account>()
				.HasMany(e => e.Comments)
				.WithRequired(e => e.Account)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Account>()
				.HasMany(e => e.OrderProducts)
				.WithRequired(e => e.Account)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Cart>()
				.Property(e => e.TotalPrice)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Cart>()
				.HasMany(e => e.ProductCartMappings)
				.WithRequired(e => e.Cart)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Category>()
				.HasMany(e => e.Products)
				.WithRequired(e => e.Category)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<News>()
				.HasMany(e => e.Comments)
				.WithRequired(e => e.News)
				.HasForeignKey(e => e.NewId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<OrderProduct>()
				.Property(e => e.Total)
				.HasPrecision(18, 4);

			modelBuilder.Entity<OrderProduct>()
				.HasMany(e => e.OrderProductContents)
				.WithRequired(e => e.OrderProduct)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<OrderProductContent>()
				.Property(e => e.Price)
				.HasPrecision(18, 4);

			modelBuilder.Entity<OrderProductContent>()
				.Property(e => e.Amount)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.Price)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.SalePrice)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.Quantity)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.OrderProductContents)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.ProductCartMappings)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Status>()
				.HasMany(e => e.Accounts)
				.WithRequired(e => e.Status)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Status>()
				.HasMany(e => e.Categories)
				.WithRequired(e => e.Status)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Status>()
				.HasMany(e => e.Products)
				.WithRequired(e => e.Status)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Status>()
				.HasMany(e => e.UnitOfMeasures)
				.WithRequired(e => e.Status)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Supplier>()
				.Property(e => e.Phone)
				.IsFixedLength();

			modelBuilder.Entity<Supplier>()
				.HasMany(e => e.Products)
				.WithRequired(e => e.Supplier)
				.HasForeignKey(e => e.BuyerStoreId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<UnitOfMeasure>()
				.HasMany(e => e.OrderProductContents)
				.WithRequired(e => e.UnitOfMeasure)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<UnitOfMeasure>()
				.HasMany(e => e.Products)
				.WithRequired(e => e.UnitOfMeasure)
				.WillCascadeOnDelete(false);
		}
	}
}
