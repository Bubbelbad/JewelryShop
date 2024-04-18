using JewelryShopWebApi.Models;

namespace JewelryShopWebApi.Services
{
    public class OrderService
    {
        List<Order> orders = new List<Order>();

        public OrderService() 
        { 
            orders.Add(new Order(1, 100, DateTime.Now));
            orders.Add(new Order(2, 200, DateTime.Now));
            orders.Add(new Order(3, 300, DateTime.Now));
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

        public bool UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}
