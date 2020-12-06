using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.ExternalContracts
{
    public interface ICustomerService
    {
        Customer SelectCustomerById(int customerId);
        IEnumerable<Customer> SelectAllCustomers();
        int CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        Customer Exists(Customer customer);
    }
}
