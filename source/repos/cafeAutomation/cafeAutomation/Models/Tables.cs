namespace CafeAutomation.Models
{
    public class Tables
    {
        public int ID { get; set; } // Primary Key
        public string TableNo { get; set; } // Masa numarası
        public string Status { get; set; } // Masanın durumu (örneğin: Dolu, Boş)

        // Navigation Property
        public ICollection<Orders> Orders { get; set; } // Bir masa birden fazla sipariş alabilir
    }
}
