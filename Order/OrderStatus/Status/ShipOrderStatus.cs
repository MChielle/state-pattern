using state_pattern.Order.OrderStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_pattern.Order.OrderStatus.Status
{
    internal class ShipOrderStatus : IOrderStatus
    {
        public void CancelOrder(Order order)
        {
            order.SetStatus(new CancelOrderStatus());
        }

        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void ProcessOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void ShipOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
