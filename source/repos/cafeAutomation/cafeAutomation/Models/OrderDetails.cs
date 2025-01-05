namespace CafeAutomation.Models
{
    public class OrderDetails
    {
        public int ID { get; set; } // Primary Key
        public int OrderID { get; set; } // Foreign Key (Sipariş ID)
        public int ProductID { get; set; } // Foreign Key (Ürün ID)
        public int Quantity { get; set; } // Sipariş edilen miktar
        public decimal TotalAmount { get; set; } // Toplam tutar

        // Navigation Properties
        public Orders Order { get; set; } // Bir OrderDetail bir siparişe aittir
        public Products Product { get; set; } // Bir OrderDetail bir ürüne aittir
    }
}
