using state_pattern.Order.OrderStates;

namespace state_pattern.Order.OrderStatus.Status
{
    internal class CancelOrderStatus : IOrderStatus
    {
        public void CancelOrder(Order order)
        {
            throw new ApplicationException("The order has been already canceled");
        }

        public void CreateOrder(Order order)
        {
            throw new ApplicationException("The order has been already canceled");
        }

        public void ProcessOrder(Order order)
        {
            throw new ApplicationException("The order has been already canceled");
        }

        public void ShipOrder(Order order)
        {
            throw new ApplicationException("The order has been already canceled");
        }
    }
}