using state_pattern.Order.OrderStates;
using state_pattern.Order.OrderStatus.Status;

namespace state_pattern.Order
{
    internal class Order
    {
        public IOrderStatus Status { get; private set; }

        public Order()
        {
            Status = new CreateOrderStatus();
        }

        public void SetStatus(IOrderStatus status)
        {
            this.Status = status;
        }

        public void CancelOrder()
        {
            Status.CancelOrder(this);
        }

        public void CreateOrder()
        {
            Status.CreateOrder(this);
        }

        public void ProcessOrder()
        {
            Status.ProcessOrder(this);
        }

        public void ShipOrder()
        {
            Status.ShipOrder(this);
        }
    }
}