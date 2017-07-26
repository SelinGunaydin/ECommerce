using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-2D1L3JM; Database=ECommerceDB;Trusted_connection=true";
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


    }
}
