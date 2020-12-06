using AnyCompany.Infrastructure;

namespace AnyCompany.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private CustomerDbContext _dbContext;
        private readonly IDatabaseFactory _databaseFactory;
        private ICustomerRepository _customerRepository;
        private IOrderRepository _orderRepository;

        public CustomerDbContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbContext = _databaseFactory.GetDbContext());
            }
        }

        public UnitOfWork(IDatabaseFactory databaseFactory) => _databaseFactory = databaseFactory;

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                return _customerRepository ?? (_customerRepository = new CustomerRepository(_databaseFactory));
            }
        }

        public IOrderRepository OrderRepository
        {
            get { return _orderRepository ?? (_orderRepository = new OrderRepository(_databaseFactory)); }
        }
    }
}
