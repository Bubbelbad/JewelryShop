using JewelryShop.Models;
using JewelryShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.ObjectModel;

namespace JewelryShop.Pages.ShoppingCartPage
{
    public class ShoppingCartModel : PageModel
    {
        public ObservableCollection<Product> shoppingCart = new ObservableCollection<Product>(); //En lista som innehåller produkterna i kundvagnen
        public ShoppingCartService shoppingCartService; 

        public ShoppingCartModel(ShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
            shoppingCart.Add(new Product(1, 199.50, 8.5, "ring1.jpg", "Silver", "Ring", "somtehing"));
            shoppingCart.Add(new Product(2, 299.50, 9, "ring2.jpg", "Silver", "Ring", "somtehing"));
            shoppingCart.Add(new Product(3, 49.50, 7.5, "ring3.jpg", "Silver", "Ring", "somtehing"));
        }

        public void OnGet()
        {
            //shoppingCart = shoppingCartService.GetShoppingCartList();
        }
    }
}
