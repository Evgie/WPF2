using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ViewModel.ClientViewModel
{
    public class ProductsListViewModel : INotifyPropertyChanged
    {
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

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get
            {
                return this.selectedProduct;
            }
            set
            {
                if (this.selectedProduct == value)
                    return;

                this.selectedProduct = value;
                this.OnPropertyChanged(nameof(this.SelectedProduct));
                this.ProductDetailedViewModel = new ProductDetailedViewModel(this.SelectedProduct);
            }
        }

        private ProductDetailedViewModel productDetailedViewModel;
        public ProductDetailedViewModel ProductDetailedViewModel
        {
            get
            {
                return this.productDetailedViewModel;
            }
            set
            {
                if (this.productDetailedViewModel == value)
                    return;

                this.productDetailedViewModel = value;
                this.OnPropertyChanged(nameof(this.ProductDetailedViewModel));

            }
        }

        public ProductsListViewModel(ObservableCollection<Product> products)
        {
            this.Products = products;
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
