using System;
using System.Collections.Generic;

namespace Task2_2.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public Guid? StoreId { get; set; }
        public Guid CustomerId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Phone { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public string DeliveryStreet { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryZip { get; set; }
        public decimal ItemsTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
