using JewelryShop.Models;
using JewelryShop.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelryShop.Pages.ProductPage
{
    public class ProductModel : PageModel
    {
        HttpRequestSender httpRequestSender;
        ShoppingCartService shoppingCartService;
        public Product product;

        public ProductModel(HttpRequestSender httpRequestSender)
        {
            this.httpRequestSender = httpRequestSender;
            this.shoppingCartService = new ShoppingCartService();
        }

        public void OnGet()
        {  
            string id = Request.Query["id"];
            product = httpRequestSender.GetProductById(id);
        }

        public void OnPost(int id)
        {
            Product product = httpRequestSender.GetProductById(id.ToString());
            shoppingCartService.AddProduct(product);
        }
    }
}
