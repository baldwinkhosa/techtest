using System;
using System.Linq.Expressions;


namespace AnyCompany.Infrastructure
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetCustomerFromCustomerName(Expression<Func<Customer, bool>> where);
    }
}
