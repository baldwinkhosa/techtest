using System;
using AnyCompany.ExternalContracts;
using AnyCompany.IOC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace AnyCompany.UnitTests
{
    [TestClass]
    public class AnyCompanyTest
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;

        public AnyCompanyTest(ICustomerService customerService, IOrderService orderService)
        {
            _customerService = customerService;
            _orderService = orderService;
        }

        [TestMethod]
        public void AllModuleBindingsTest()
        {
            IKernel kernel = new StandardKernel(new NinjectBindings());
            foreach (var binding in new NinjectBindings().Bindings)
            {
                var result = kernel.Get(binding.Service);
                Assert.IsNotNull(result, $"Could not get {binding.Service}");
            }
        }
        [TestMethod]
        public void PlaceOrder()
        {
            Order order = new Order()
            {
                Amount = 10,
                VAT = 0,
            };

           var result =  _orderService.CreateOrder(order);
            Assert.AreSame(result, "0");
        }
    }
}
