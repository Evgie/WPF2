using System;
using System.Collections.Generic;

namespace Task2_2.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            OrderItemOption = new HashSet<OrderItemOption>();
        }

        public long Id { get; set; }
        public Guid? StoreId { get; set; }
        public long OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductSizeId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Instructions { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        public virtual ICollection<OrderItemOption> OrderItemOption { get; set; }
    }
}
