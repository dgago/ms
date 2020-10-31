using Microsoft.EntityFrameworkCore;

namespace ef
{
    public class TestContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=blogging.db");
        }
    }
}
