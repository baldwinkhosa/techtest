using AnyCompany.ExternalContracts;
using AnyCompany.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateCustomer(Customer customer)
        {
            bool userExists = _unitOfWork.CustomerRepository.Exists(u => u.Name == customer.Name);

            if (userExists)
            {
                return 0;
            }

            _unitOfWork.CustomerRepository.Insert(customer);
            _unitOfWork.Commit();

            return customer.Id;
        }

        public void DeleteCustomer(int customerId)
        {
            _unitOfWork.CustomerRepository.Delete(SelectCustomerById(customerId));
        }

        public Customer Exists(Customer customer)
        {
            bool validUser = _unitOfWork.CustomerRepository.Exists(u => u.Name == customer.Name);
            return validUser ? _unitOfWork.CustomerRepository.GetCustomerFromCustomerName(u => u.Name == customer.Name) : null;
        }

        public IEnumerable<Customer> SelectAllCustomers()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }

        public Customer SelectCustomerById(int customerId)
        {
            return _unitOfWork.CustomerRepository.Single(customerId);
        }

        public void UpdateCustomer(Customer customer)
        {
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.Commit();
        }
    }
}
