using System;
using System.Collections.Generic;

namespace Task2_2.Models
{
    public partial class OrderItemOption
    {
        public long Id { get; set; }
        public Guid? StoreId { get; set; }
        public long OrderItemId { get; set; }
        public int ProductOptionId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual ProductOption ProductOption { get; set; }
    }
}
