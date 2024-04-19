using JewelryShopWebApi.Models;
using System.Reflection.Metadata.Ecma335;

namespace JewelryShopWebApi.Services
{
    public class ProductService
    {
        public List<Product> products = new List<Product>();

        public ProductService()
        {
            products.Add(new Product(1, 199.50, 8.5, "Silver", "Ring"));
            products.Add(new Product(2, 299.50, 9, "Silver", "Ring"));
            products.Add(new Product(3, 49.50, 7.5, "Silver", "Ring"));
        }


        public List<Product> GetProducts()
        {
            return products;
        }


        public Product GetProductById(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            return product;
        }


        public bool CreateProduct(Product product)
        {
            if (product != null) //Kanske lägga in det där som var .Value för att kolla alla värden är korrekt? 
            {
                products.Add(product);
                return true;
            }
            return false; 
        }

        public bool UpdateProduct()
        {
            throw new NotImplementedException();
        }


        public bool DeleteProduct(int id)
        {
            Product product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
