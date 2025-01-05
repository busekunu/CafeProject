namespace CafeAutomation.Models
{
    public class Orders
    {
        public int ID { get; set; } // Primary Key
        public int TableID { get; set; } // Foreign Key (Masa ID)
        public DateTime OrderDate { get; set; } // Sipariş tarihi
        public string Status { get; set; } // Sipariş durumu (Hazırlanıyor, Tamamlandı)

        // Navigation Properties
        public Tables Table { get; set; } // Bir sipariş bir masaya aittir
        public ICollection<OrderDetails> OrderDetails { get; set; } // Bir sipariş birden fazla ürünü içerebilir
        public Payments Payment { get; set; } // Bir sipariş bir ödeme alır (One-to-One ilişki)
    }
}
