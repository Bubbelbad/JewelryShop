using JewelryShop.Models;
using JewelryShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelryShop.Pages.Shop
{
    public class ShopModel : PageModel
    {
        HttpRequestSender  httpRequestSender;
        //Enklass jag skapar själv

        public List<Product> products = new List<Product>();

        public ShopModel(HttpRequestSender httpRequestSender)
        {
            this.httpRequestSender = httpRequestSender;
        }


        public void OnGet()
        {
            products = httpRequestSender.GetProducts();
        }
    }
}
