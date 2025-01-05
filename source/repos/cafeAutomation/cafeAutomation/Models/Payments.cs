namespace CafeAutomation.Models
{
    public class Payments
    {
        public int ID { get; set; } // Primary Key
        public int OrderID { get; set; } // Foreign Key (Sipariş ID)
        public decimal Amount { get; set; } // Ödeme tutarı
        public string PaymentMethod { get; set; } // Ödeme yöntemi (Nakit, Kredi Kartı, QR)
        public DateTime Date { get; set; } // Ödeme tarihi

        // Navigation Property
        public Orders Order { get; set; } // Bir ödeme bir siparişe aittir
    }
}
