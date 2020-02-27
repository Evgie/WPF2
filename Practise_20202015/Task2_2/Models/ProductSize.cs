using System;
using System.Collections.Generic;

namespace Task2_2.Models
{
    public partial class ProductSize
    {
        public ProductSize()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? PremiumPrice { get; set; }
        public decimal? ToppingPrice { get; set; }
        public bool? IsGlutenFree { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
