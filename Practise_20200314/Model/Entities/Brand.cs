using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public ObservableCollection<Product> Products { get; set; }
    }
}
