using JewelryShopWebApi.Models;
using System.Reflection.Metadata.Ecma335;

namespace JewelryShopWebApi.Services
{
    public class ProductService
    {
        public List<Product> products { get; set; }

        public ProductService()
        {
            products.Add(new Product(1, 199.50, 8.5, "Silver", "Ring"));
            products.Add(new Product(2, 299.50, 9, "Silver", "Ring"));
            products.Add(new Product(1, 49.50, 7.5, "Silver", "Ring"));
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

        public bool DeleteProduct(Product product)
        {
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        public bool UpdateProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return products;
        }

    }
}
