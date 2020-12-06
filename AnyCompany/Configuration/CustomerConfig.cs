using System.Data.Entity.ModelConfiguration;

namespace AnyCompany.Configuration
{
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasMany(c => c.Orders).WithOptional().HasForeignKey(c => c.CustomerId);
        }
    }
}
