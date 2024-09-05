using Microsoft.EntityFrameworkCore;

namespace WebAbiHomework5.Entities
{
    public class EcommerceDBContext:DbContext
    {
        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options):base(options)
        {
            
        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
