namespace JewelryShopWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }
        public string Material { get; set; }
        public string Category { get; set; }

        public Product()
        {

        }

        public Product(int id, double price, double size, string material, string category)
        {
            this.Id = id;
            this.Price = price;
            this.Size = size;
            this.Material = material;
            this.Category = category;
        }
    }
}
