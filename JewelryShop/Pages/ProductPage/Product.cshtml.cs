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
        public Product product;

        public ProductModel(HttpRequestSender httpRequestSender)
        {
            this.httpRequestSender = httpRequestSender;
        }

        public void OnGet()
        {   string id = Request.Query["id"];
            product = httpRequestSender.GetProductById(id);
        }
    }
}
