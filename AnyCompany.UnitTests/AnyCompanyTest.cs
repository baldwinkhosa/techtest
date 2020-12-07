using System;
using AnyCompany.IOC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace AnyCompany.UnitTests
{
    [TestClass]
    public class AnyCompanyTest
    {
        public static readonly IKernel Instance = new StandardKernel(new NinjectBindings());

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
        public void TestMethod1()
        {
        }
    }
}
