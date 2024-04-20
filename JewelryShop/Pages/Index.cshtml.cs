using JewelryShop.Models;
using JewelryShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelryShop.Pages
{
    public class IndexModel : PageModel
    {
        HttpRequestSender HttpRequestSender;
        public List<Product> springCollection { get; set; }
        
        public IndexModel(HttpRequestSender httpRequestSender)
        {
            this.HttpRequestSender = httpRequestSender;
        }

        public void OnGet()
        {
            springCollection = HttpRequestSender.GetProducts();
        }
    }
}
