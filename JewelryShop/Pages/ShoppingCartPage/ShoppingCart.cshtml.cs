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
        }

        public void OnGet()
        {
            shoppingCart = shoppingCartService.GetShoppingCartList();
        }
    }
}
