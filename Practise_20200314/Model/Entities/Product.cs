using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ModelYear { get; set; }
        public decimal ListPrice { get; set; }

        public ObservableCollection<OrderItem> OrderItems { get; set; }
        public ObservableCollection<Stock> Stocks { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
    }
}
