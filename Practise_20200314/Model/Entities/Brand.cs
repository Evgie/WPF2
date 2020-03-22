using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Model.Entities
{
    public class Brand : INotifyPropertyChanged
    {
        public int BrandId { get; set; }

        private string brandName;
        public string BrandName
        {
            get
            {
                return this.brandName;
            }
            set
            {
                if (this.brandName == value)
                    return;

                this.brandName = value;
                this.OnPropertyChanged(nameof(this.BrandName));
            }
        }

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get
            {
                return this.products;
            }
            set
            {
                if (this.products == value)
                    return;

                this.products = value;
                this.OnPropertyChanged(nameof(this.Products));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {            
            return this.BrandName.ToString();
        }
    }
}
