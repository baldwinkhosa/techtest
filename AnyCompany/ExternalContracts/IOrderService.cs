using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.ExternalContracts
{
    public interface IOrderService
    {
        int CreateOrder(Order order);
        Order SelectOrderById(int orderId);
        IEnumerable<Order> SelectAllOrder();
        void EditContact(Order order);
        void DeleteContact(int contactId);
    }
}
