using AnyCompany.ExternalContracts;
using AnyCompany.Infrastructure;
using AnyCompany.Repository;
using AnyCompany.Services;
using Ninject.Modules;

namespace AnyCompany.IOC
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatabaseFactory>().To<DatabaseFactory>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ICustomerService>().To<CustomerService>();
            Bind<IOrderService>().To<OrderService>();
        }
    }
}
