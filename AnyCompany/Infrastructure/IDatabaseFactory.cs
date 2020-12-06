using System;

namespace AnyCompany.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        CustomerDbContext GetDbContext();
    }
}
