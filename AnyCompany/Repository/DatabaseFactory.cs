using AnyCompany.Infrastructure;
using System;

namespace AnyCompany.Repository
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private CustomerDbContext _dbContext;
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public CustomerDbContext GetDbContext()
        {
            return _dbContext ?? (_dbContext = new CustomerDbContext());
        }
    }
}
