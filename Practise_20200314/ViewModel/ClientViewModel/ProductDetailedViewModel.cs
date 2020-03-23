using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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

        private int totalQuantity;
        public int TotalQuantity
        {
            get
            {
                return this.totalQuantity;
            }
            set
            {
                if (this.totalQuantity == value)
                    return;

                this.totalQuantity = value;
                this.OnPropertyChanged(nameof(this.TotalQuantity));
            }
        }

        public ProductDetailedViewModel(Product product)
        {
            this.Product = product;
            this.CountTotalQuantity();
        }

        private void CountTotalQuantity()
        {
            int currentId = this.Product.ProductId;
            this.TotalQuantity = this.Product.Stocks
                .Where(s => s.ProductId == currentId)
                .Select(s => s.Quantity)
                .Sum();
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
