using Microsoft.AspNetCore.Mvc;
using OrderService.Data;
using OrderService.Models;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {

        private readonly OrderDbContext _context;
        public OrdersController(OrderDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Orders.ToList());


        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrdersById(int id)
        {
            var orders = _context.Orders.Where(orders => orders.OrderId == id).ToList();
            return Ok(orders);
        }


    }
}
