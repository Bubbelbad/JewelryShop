using JewelryShop.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JewelryShop.Services
{
    public class HttpRequestSender
    {
        public List<Product> GetProducts()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response= client.GetAsync("https://localhost:7138/api/Product").Result;
            List<Product> products = new List<Product>();

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            return products; 
        }

        public Product GetProduct(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:44300/api/products/" + id).Result;
            Product product = new Product();

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<Product>(json);
            }

            return product; 
        }
    }
}
