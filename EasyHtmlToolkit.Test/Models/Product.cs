namespace EasyHtmlToolkit.Test.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public int StockQuantity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public Product(string name, decimal price, string imageUrl, string description, string category, string manufacturer, int stockQuantity, DateTime manufactureDate)
        {
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Description = description;
            Category = category;
            Manufacturer = manufacturer;
            StockQuantity = stockQuantity;
            ManufactureDate = manufactureDate;
        }
    }
}
