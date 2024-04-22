using JewelryShopWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelryShopWebApi.Services
{
    public class OrderService
    {
        List<Order> orders = new List<Order>();
        DatabaseContext db; 

        public OrderService(DatabaseContext db) 
        { 
            this.db = db;
        }
        public List<Order> GetOrders()
        {
            return db.Orders.Include(order => order.Products).ToList();
        }

        public Order GetOrderById(int id)
        {
            return db.Orders.Find(id);
        }

        public bool CreateOrder(Order order)
        {
            if (order != null)
            {
                orders.Add(order);
                return true;
            }
            return false;
        }

        public bool DeleteOrder(Order order)
        {
            if (order != null)
            {
                orders.Remove(order);
                return true;
            }
            return false;
        }

        public bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
