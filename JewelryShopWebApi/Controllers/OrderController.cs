using JewelryShopWebApi.Models;
using JewelryShopWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace JewelryShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }


        //https://localhost:7138/api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            List<Order> orders = orderService.GetOrders();
            if (orders != null)
            {
                return Ok(orders);
            }
            return NotFound();
        }

        //https://localhost:7138/api/Order/byid?id=1
        [HttpGet("byid")]
        public ActionResult<Order> GetOrder(int id)
        {
            Order order = orderService.GetOrders().FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                return Ok(order);
            }
            return NotFound();
        }

        //https://localhost:7138/api/Order/add
        [HttpPost("add")]
        public ActionResult CreateOrder(Order order)
        {
            bool success = orderService.CreateOrder(order);
            if (success)
            {
                return StatusCode(201);
            }
            return BadRequest();
        }

        //https://localhost:7138/api/Order/delete
        [HttpDelete("delete")]
        public ActionResult DeleteOrder(Order order)
        {
            bool success = orderService.DeleteOrder(order);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
