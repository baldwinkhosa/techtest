using AnyCompany.ExternalContracts;
using AnyCompany.Infrastructure;
using System.Collections.Generic;

namespace AnyCompany
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateOrder(Order order)
        {
            _unitOfWork.OrderRepository.Insert(order);
            SaveChanges();
            return order.OrderId;
        }

        public void DeleteContact(int contactId)
        {
            Order order = SelectOrderById(contactId);
            _unitOfWork.OrderRepository.Delete(order);
            SaveChanges();
        }

        public void EditContact(Order order)
        {
            _unitOfWork.OrderRepository.Update(order);
            SaveChanges();
        }

        public IEnumerable<Order> SelectAllOrder()
        {
            return _unitOfWork.OrderRepository.GetAll();
        }

        public Order SelectOrderById(int orderId)
        {
            return _unitOfWork.OrderRepository.Single(orderId);
        }

        private void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
