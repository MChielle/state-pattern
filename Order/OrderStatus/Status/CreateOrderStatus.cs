using state_pattern.Order.OrderStates;

namespace state_pattern.Order.OrderStatus.Status
{
    internal class CreateOrderStatus : IOrderStatus
    {
        public void CancelOrder(Order order)
        {
            order.SetStatus(new CancelOrderStatus());
        }

        public void CreateOrder(Order order)
        {
            throw new ApplicationException("The order has been already created");
        }

        public void ProcessOrder(Order order)
        {
            order.SetStatus(new ProcessOrderStatus());
        }

        public void ShipOrder(Order order)
        {
            throw new ApplicationException("Order isn't ready");
        }
    }
}