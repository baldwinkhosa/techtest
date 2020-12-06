using AnyCompany.Infrastructure;
using AnyCompany.Repository;

namespace AnyCompany
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {

        }
    }
}
