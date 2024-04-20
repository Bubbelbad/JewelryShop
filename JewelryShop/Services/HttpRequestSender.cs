using JewelryShop.Models;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

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

        public Product GetProductById(string id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:7138/api/Product/byid?id=" + id).Result;
            Product product = new Product();

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<Product>(json);
                return product;
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return product; //Need to do something else here
            }
            return product; 
        }
    }
}
