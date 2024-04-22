using JewelryShop.Models;
using JewelryShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.ObjectModel;

namespace JewelryShop.Pages.ShoppingCartPage
{
    public class ShoppingCartModel : PageModel
    {
        public List<Product> shoppingCart = new List<Product>(); //En lista som innehåller produkterna i kundvagnen
        public ShoppingCartService shoppingCartService; 
        public HttpRequestSender httpRequestSender;

        public ShoppingCartModel(ShoppingCartService shoppingCartService, HttpRequestSender httpRequestSender)
        {
            this.shoppingCartService = shoppingCartService;
            this.httpRequestSender = httpRequestSender;
        }

        public void OnGet()
        {
            shoppingCart = shoppingCartService.GetShoppingCartList();
        }

        public IActionResult OnPostRemoveItem(int idToDelete)
        {
            shoppingCartService.DeleteProduct(idToDelete);
            return RedirectToPage();
        }
    }
}
