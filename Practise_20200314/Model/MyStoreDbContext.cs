using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;

namespace Model
{
    public class MyStoreDbContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Database = MyStore; Trusted_Connection = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            //OrderItems.
            //
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ItemId });

            modelBuilder.Entity<OrderItem>()
                .ToTable("order_items (sales)")
                .Property(oi => oi.OrderId)
                .HasColumnName("order_id");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.ItemId)
                .HasColumnName("item_id");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.ProductId)
                .HasColumnName("product_id");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Quantity)
                .HasColumnName("quantity");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.ListPrice)
                .HasColumnName("list_price");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Discount)
                .HasColumnName("discount");

            //
            //Customers.
            //
            modelBuilder.Entity<Customer>(c =>
            {
                c.ToTable("customers (sales)");
                c.Property(c => c.CustomerId)
                .HasColumnName("customer_id");
                c.Property(c => c.FirstName)
                .HasColumnName("first_name");
                c.Property(c => c.LastName)
                .HasColumnName("last_name");
                c.Property(c => c.Phone)
                .HasColumnName("phone");
                c.Property(c => c.Email)
                .HasColumnName("email");
                c.Property(c => c.Street)
                .HasColumnName("street");
                c.Property(c => c.City)
                .HasColumnName("city");
                c.Property(c => c.State)
                .HasColumnName("state");
                c.Property(c => c.ZipCode)
                .HasColumnName("zip_code");
            });

            //
            //Stocks.
            //
            modelBuilder.Entity<Stock>(s =>
            {
                s.HasKey(s => new { s.StoreId, s.ProductId });
                s.ToTable("stocks (production)");
                s.Property(s => s.StoreId)
                .HasColumnName("store_id");
                s.Property(s => s.ProductId)
                .HasColumnName("product_id");
                s.Property(s => s.Quantity)
                .HasColumnName("quantity");
            });

            //
            //Orders.
            //
            modelBuilder.Entity<Order>(o =>
            {
                o.HasOne<Store>(o => o.Store)
                .WithMany(s => s.Orders)
                .OnDelete(DeleteBehavior.NoAction);

                o.ToTable("orders (sales)");
                o.Property(o => o.OrderId)
                .HasColumnName("order_id");
                o.Property(o => o.CustomerId)
                .HasColumnName("customer_id");
                o.Property(o => o.OrderStatus)
                .HasColumnName("order_status");
                o.Property(o => o.OrderDate)
                .HasColumnName("order_date");
                o.Property(o => o.StoreId)
                .HasColumnName("store_id");
            });

            //
            //Staffs.
            //
            modelBuilder.Entity<Staff>(s =>
            {
                s.ToTable("staffs (sales)");
                s.Property(s => s.StaffId)
                .HasColumnName("staff_id");
                s.Property(s => s.FirstName)
                .HasColumnName("first_name");
                s.Property(s => s.LastName)
                .HasColumnName("last_name");
                s.Property(s => s.Email)
                .HasColumnName("email");
                s.Property(s => s.Phone)
                .HasColumnName("phone");
                s.Property(s => s.Active)
                .HasColumnName("active");
                s.Property(s => s.StoreId)
                .HasColumnName("store_id");
                s.Property(s => s.ManagerId)
                .HasColumnName("manager_id");
            });

            modelBuilder.Entity<Store>(s =>
            {
                s.ToTable("stores (sales)");
                s.Property(s => s.StoreId)
                .HasColumnName("store_id");
                s.Property(s => s.StoreName)
                .HasColumnName("store_name");
                s.Property(s => s.Phone)
                .HasColumnName("phone");
                s.Property(s => s.Email)
                .HasColumnName("email");
                s.Property(s => s.Street)
                .HasColumnName("street");
                s.Property(s => s.City)
                .HasColumnName("city");
                s.Property(s => s.State)
                .HasColumnName("state");
                s.Property(s => s.ZipCode)
                .HasColumnName("zip_code");
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("products (production)");
                p.Property(p => p.ProductId)
                .HasColumnName("product_id");
                p.Property(p => p.ProductName)
                .HasColumnName("product_name");
                p.Property(p => p.BrandId)
                .HasColumnName("brand_id");
                p.Property(p => p.CategoryId)
                .HasColumnName("category_id");
                p.Property(p => p.ModelYear)
                .HasColumnName("model_year");
                p.Property(p => p.ListPrice)
                .HasColumnName("list_price");
            });

            modelBuilder.Entity<Brand>(b =>
            {
                b.ToTable("brands (production)");
                b.Property(b => b.BrandId)
                .HasColumnName("brand_id");
                b.Property(b => b.BrandName)
                .HasColumnName("brand_name");
            });

            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("categories (production)");
                c.Property(c => c.CategoryId)
                .HasColumnName("brand_id");
                c.Property(c => c.CategoryName)
                .HasColumnName("category_name");
            });

            //
            //Initializing DB.
            //
            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer[]
                {
                    new Customer { CustomerId = 1, FirstName = "Tom", LastName = "Hanks", Phone = "112233", Email = "t.hanks@gmail.com"},
                    new Customer { CustomerId = 2, FirstName = "Alice", LastName = "Potter", Phone = "911", Email = "a.potter@gmail.com"}
                });

            modelBuilder.Entity<Store>()
                .HasData(
                new Store[]
                {
                    new Store {StoreId = 1, StoreName = "Nike"},
                    new Store {StoreId = 2, StoreName = "Walmart"}
                });

            modelBuilder.Entity<Staff>()
                .HasData(
                new Staff[]
                {
                    new Staff {StaffId = 1, StoreId = 1, FirstName = "Sam", LastName = "Newton", ManagerId = 1},
                    new Staff {StaffId = 2, StoreId = 1, FirstName = "Bill", LastName = "Clinton", ManagerId = 2}
                });

            modelBuilder.Entity<Order>()
                .HasData(
                new Order[]
                {
                    new Order {OrderId = 1, CustomerId = 1, OrderStatus = "Delivered", StoreId = 1, StaffId = 1},
                    new Order {OrderId = 2, CustomerId = 1, OrderStatus = "Ready for delivery", StoreId = 2, StaffId = 2},
                    new Order {OrderId = 3, CustomerId = 2, OrderStatus = "Ordered", StoreId = 2, StaffId = 1},
                });

            modelBuilder.Entity<Stock>()
                .HasData(
                new Stock[]
                {
                    new Stock {StoreId = 1, ProductId = 1, Quantity = 10},
                    new Stock {StoreId = 1, ProductId = 2, Quantity = 3},
                    new Stock {StoreId = 2, ProductId = 1, Quantity = 21},
                    new Stock {StoreId = 2, ProductId = 2, Quantity = 100}
                });

            modelBuilder.Entity<OrderItem>()
                .HasData(
                new OrderItem[]
                {
                    new OrderItem {OrderId = 1, ItemId = 1, ProductId = 1, Quantity = 3, ListPrice = 10m, Discount = 0},
                    new OrderItem {OrderId = 1, ItemId = 2, ProductId = 2, Quantity = 1, ListPrice = 150m, Discount = 0},
                    new OrderItem {OrderId = 2, ItemId = 3, ProductId = 1, Quantity = 1, ListPrice = 11m, Discount = 5},
                    new OrderItem {OrderId = 2, ItemId = 4, ProductId = 2, Quantity = 2, ListPrice = 140m, Discount = 0}
                });

            modelBuilder.Entity<Product>()
                .HasData(
                new Product[]
                {
                    new Product {ProductId = 1, ProductName = "Sneakers", BrandId = 1, CategoryId = 1, ModelYear = 2000},
                    new Product {ProductId = 2, ProductName = "Jeans", BrandId = 2, CategoryId = 2, ModelYear = 2000}
                });

            modelBuilder.Entity<Category>()
                .HasData(
                new Category[]
                {
                    new Category {CategoryId = 1, CategoryName = "Shoes"},
                    new Category {CategoryId = 2, CategoryName = "Clothes"}
                });

            modelBuilder.Entity<Brand>()
                .HasData(
                new Brand[]
                {
                    new Brand {BrandId = 1, BrandName = "Nike"},
                    new Brand {BrandId = 2, BrandName = "Levis"}
                });
        }
    }
}
