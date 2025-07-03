using state_pattern.Order.OrderStates;

namespace state_pattern.Order.OrderStatus.Status
{
    internal class ProcessOrderStatus : IOrderStatus
    {
        public void CancelOrder(Order order)
        {
            order.SetStatus(new CancelOrderStatus());
        }

        public void CreateOrder(Order order)
        {
            throw new ApplicationException("The order has been already processed");
        }

        public void ProcessOrder(Order order)
        {
            throw new ApplicationException("The order is in process");
        }

        public void ShipOrder(Order order)
        {
            order.SetStatus(new ShipOrderStatus());
        }
    }
}