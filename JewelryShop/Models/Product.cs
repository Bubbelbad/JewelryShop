using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JewelryShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        public double Size { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        [MaxLength(20)]
        public string Color { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(int id, double price, double size, string Image, string brand, string color, string category)
        {
            this.Id = id;
            this.Price = price;
            this.Size = size;
            this.Image = Image;
            this.Brand = brand;
            this.Color = color;
            this.Category = category;
        }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
