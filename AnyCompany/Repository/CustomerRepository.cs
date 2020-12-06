using AnyCompany.Infrastructure;
using AnyCompany.Repository;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace AnyCompany
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
        public Customer GetCustomerFromCustomerName(Expression<Func<Customer, bool>> where)
        {
            return DbContext.Set<Customer>().Single(where);
        }
    }
}
