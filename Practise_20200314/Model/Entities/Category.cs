using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Model.Entities
{
    public class Category : INotifyPropertyChanged
    {
        public int CategoryId { get; set; }

        private string categoryName;
        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }
            set
            {
                if (this.categoryName == value)
                    return;

                this.categoryName = value;
                this.OnPropertyChanged(nameof(this.CategoryName));
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
    }
}
