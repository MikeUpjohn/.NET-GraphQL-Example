using GraphQLExample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExample.Data
{
    public class OrdersContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
