using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_pattern.Order.OrderStates
{
    internal interface IOrderStatus
    {
        void CreateOrder(Order order);
        void ProcessOrder(Order order);
        void ShipOrder(Order order);
        void CancelOrder(Order order);
    }
}
