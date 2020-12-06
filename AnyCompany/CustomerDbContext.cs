using System.Data.Entity;

namespace AnyCompany
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext() : base ("CustomerConString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CustomerDbContext>());
        }

        public DbSet<Customer> Customers;
        public DbSet<Order> Orders;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
        }
    }
}
