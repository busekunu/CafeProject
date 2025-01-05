namespace CafeAutomation.Models
{
    public class Products
    {
        public int ID { get; set; } // Primary Key
        public string ProductName { get; set; } // Ürün adı
        public decimal Price { get; set; } // Fiyat
        public int StockAmount { get; set; } // Stok miktarı

        // Navigation Property
        public ICollection<OrderDetails> OrderDetails { get; set; } // Bir ürün birden fazla siparişte yer alabilir
    }
}
