using JewelryShop.Models;

namespace JewelryShop.Services
{
    public class ShoppingCartService
    {
        public List<Product> shoppingCart = new List<Product>();

        public ShoppingCartService()
        {
        }

        public List<Product> GetShoppingCartList()
        {
            return shoppingCart;
        }

        public void AddProduct(Product product)
        {
            shoppingCart.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            shoppingCart.Remove(product);
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in shoppingCart)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
