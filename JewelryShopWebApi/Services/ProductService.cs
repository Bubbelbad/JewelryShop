using JewelryShopWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace JewelryShopWebApi.Services
{
    public class ProductService
    {
        public List<Product> products;
        DatabaseContext db;

        public ProductService(DatabaseContext db)
        {
            this.db = db;
        }


        public List<Product> GetProducts()
        {
            products = db.Products.ToList();
            return products;
        }


        public Product GetProductById(int id)
        {
            Product product = db.Products.Find(id);
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

        public bool UpdateProduct(Product product)
        {
            if (product.Id != 0)
            {
                return false;
            }
            Product productToUpdate = db.Products.Find(product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Price = product.Price;
                productToUpdate.Size = product.Size;
                productToUpdate.Image = product.Image;
                productToUpdate.Brand = product.Brand;
                productToUpdate.Color = product.Color;
                productToUpdate.Category = product.Category;

                db.SaveChanges(); //Här sparas det i databasen!
                return true;
            }
            return false; 
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
