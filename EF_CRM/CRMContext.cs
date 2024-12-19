using Microsoft.EntityFrameworkCore;

namespace EF_CRM
{
    public class CRMContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = EF_CRM; " +
                //"Integrated Security = true; Encrypt=false");

            optionsBuilder.UseSqlServer("Data Source = 192.168.1.48; Initial Catalog = EF_CRM; " +
                    "User = 'sa'; Password = '!Abc123456'; Encrypt=false");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
