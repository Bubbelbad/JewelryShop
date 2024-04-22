using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JewelryShopWebApi.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto increment
      //  [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //Random tror jag. Vissa föredrar
        public int Id { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }

        public Product() { }

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
    }
}
