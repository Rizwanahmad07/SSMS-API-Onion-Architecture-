using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        public IOrderStatus _status;
        public OrderStatusController(IOrderStatus status)
        {
            _status = status;
        }
        [HttpGet]
        public IActionResult GetAllOrderStatus()
        {
            return Ok(_status.GetAllOrderStatus());
        }
        [HttpGet("{id}")]
        public IActionResult GetOrderStatus(int id)
        {
            return Ok(_status.GetOrderStatusById(id));
        }
        [HttpPost]
        public IActionResult AddOrderStatus(OrderStatus orderStatus)
        {
            return Ok(_status.AddOrderStatus(orderStatus));
        }
        [HttpPut]
        public IActionResult UpdateOrderStatus(OrderStatus orderStatus)
        {
            return Ok(_status.UpdateOrderStatus(orderStatus));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderStatus(int id)
        {
            return Ok(_status.DeleteOrderStatus(id));
        }

    }
}
