using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryShopWebApi.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public Order()
        {

        }

        public Order(int id, double totalPrice, DateTime date)
        {
            this.Id = id;
            this.TotalPrice = totalPrice;
            this.OrderDate = date;
        }
    }
}
