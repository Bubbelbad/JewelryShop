using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JewelryShop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public Order() { }

        public Order(int id, double totalPrice, DateTime date)
        {
            this.Id = id;
            this.TotalPrice = totalPrice;
            this.OrderDate = date;
        }
    }
}
