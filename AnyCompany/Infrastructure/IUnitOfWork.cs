
namespace AnyCompany.Infrastructure
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }
        void Commit();
    }
}
