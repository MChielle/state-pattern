using state_pattern.Order.OrderStates;

namespace state_pattern.Order.OrderStatus.Status
{
    internal class CancelOrderStatus : IOrderStatus
    {
        public void CancelOrder(Order order)
        {
            throw new ApplicationException("Order already canceled");
        }

        public void CreateOrder(Order order)
        {
            throw new ApplicationException("Can't create canceled order");
        }

        public void ProcessOrder(Order order)
        {
            throw new ApplicationException("Can't process canceled order");
        }

        public void ShipOrder(Order order)
        {
            throw new ApplicationException("Can't ship canceled order");
        }
    }
}