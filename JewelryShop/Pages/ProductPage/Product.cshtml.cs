using JewelryShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelryShop.Pages.ProductPage
{
    public class ProductModel : PageModel
    {
        public List<Product> productsList = new List<Product>();

        public Product soughtProduct { get; set;}

        public void OnGet(int? id)
        {
            if (id != null)
            {
                foreach (Product product in productsList)
                {
                    if (product.Id == id)
                    {
                        soughtProduct = product;
                    }
                }
            }
        }
    }
}
