using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ViewModel.ClientViewModel
{
    public class BrandsListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Brand> brands;
        public ObservableCollection<Brand> Brands
        {
            get
            {
                return this.brands;
            }
            set
            {
                if (this.brands == value)
                    return;

                this.brands = value;
                this.OnPropertyChanged(nameof(this.Brands));
            }
        }

        private Brand selectedBrand;
        public Brand SelectedBrand
        {
            get
            {
                return this.selectedBrand;
            }
            set
            {
                if (this.selectedBrand == value)
                    return;

                this.selectedBrand = value;
                this.OnPropertyChanged(nameof(this.SelectedBrand));
                this.ProductsListViewModel = new ProductsListViewModel(this.SelectedBrand.Products);
            }
        }

        private ProductsListViewModel productsListViewModel;
        public ProductsListViewModel ProductsListViewModel
        {
            get
            {
                return this.productsListViewModel;
            }
            set
            {
                if (this.productsListViewModel == value)
                    return;

                this.productsListViewModel = value;
                this.OnPropertyChanged(nameof(this.ProductsListViewModel));
            }
        }

        public BrandsListViewModel()
        {
            this.InitializeBrands();
        }

        private void InitializeBrands()
        {
            var context = new MyStoreDbContext();
            var tempBrands = context.Brands
                .Include(p => p.Products)
                .ThenInclude(s => s.Stocks)
                .ToList();
            this.Brands = new ObservableCollection<Brand>(tempBrands);

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
