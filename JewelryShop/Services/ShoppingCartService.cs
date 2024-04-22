using JewelryShop.Models;
using System.Collections.ObjectModel;

namespace JewelryShop.Services
{
    public class ShoppingCartService
    {
        public List<Product> shoppingCart = new List<Product>();

        public ShoppingCartService()
        {
            //Dessa ska inte ligga här senare, bara för att testa
            shoppingCart.Add(new Product(1, 199.50, 8.5, "ring1.jpg", "Guld", "Ring", "Guldring med diamanter"));
            shoppingCart.Add(new Product(2, 299.50, 9, "ring2.jpg", "Silver", "Ring", "Silverring med stenar"));
            shoppingCart.Add(new Product(3, 49.50, 7.5, "ring3.jpg", "Titan", "Ring", "Ring i titan"));
            shoppingCart.Add(new Product(5, 49.50, 7.5, "ring4.jpg", "Silver", "Ring", "Mörkare diamantring"));
        }

        public List<Product> GetShoppingCartList()
        {
            return shoppingCart;
        }

        public void AddProduct(Product product)
        {
            shoppingCart.Add(product);
        }

        public void DeleteProduct(int idToDelete)
        {
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Id == idToDelete)
                {
                    Product product = shoppingCart[i];
                    shoppingCart.Remove(product);
                    break;
                }
            }   
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
