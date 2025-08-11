using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Data.Repository
{
    public class OrderStatusRepo : IOrderStatus
    {
        public AppDbContext _context;
        public OrderStatusRepo(AppDbContext context)
        {
            _context = context;
        }
        public string AddOrderStatus(OrderStatus status)
        {
            _context.OrderStatuses.Add(status);
            _context.SaveChanges();
            return "OrderStatus Added Successfully!";
        }

        public string DeleteOrderStatus(int id)
        {
            OrderStatus status = _context.OrderStatuses.Find(id);
            _context.OrderStatuses.Remove(status);
            _context.SaveChanges();
            return "OrderStatus Deleted Successfully!";
        }

        public List<OrderStatus> GetAllOrderStatus()
        {
            return _context.OrderStatuses.ToList();
        }

        public OrderStatus GetOrderStatusById(int id)
        {
            return _context.OrderStatuses.Find(id);
        }

        public string UpdateOrderStatus(OrderStatus status)
        {
            _context.OrderStatuses.Update(status);
            _context.SaveChanges();
            return "OrderStatus Updated Successfully!";
        }
    }
}
