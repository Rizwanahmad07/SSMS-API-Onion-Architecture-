using SSECSAPI.Models;

namespace SSECSAPI.Data.Interface
{
    public interface IOrderStatus
    {
        public List<OrderStatus> GetAllOrderStatus();
        public OrderStatus GetOrderStatusById(int id);
        public string AddOrderStatus(OrderStatus status);
        public string UpdateOrderStatus(OrderStatus status);
        public string DeleteOrderStatus(int id);
    }
}
