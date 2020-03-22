using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ViewModel.ClientViewModel
{
    public class ProductDetailedViewModel : INotifyPropertyChanged
    {
        private Product product;
        public Product Product
        {
            get
            {
                return this.product;
            }
            set
            {
                if (this.product == value)
                    return;

                this.product = value;
                this.OnPropertyChanged(nameof(this.Product));
            }
        }

        public ProductDetailedViewModel(Product product)
        {
            this.Product = product;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
