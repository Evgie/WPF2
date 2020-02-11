using System;
using System.Collections.Generic;

namespace Practise_20200208.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool? HasOptions { get; set; }
        public bool? IsVegetarian { get; set; }
        public bool? WithTomatoSauce { get; set; }
        public string SizeIds { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
