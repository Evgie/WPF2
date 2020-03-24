using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.Entities
{
    public class Stock : INotifyPropertyChanged
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }

        private int quantity;
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (this.quantity == value)
                    return;

                this.quantity = value;
                this.OnPropertyChanged(nameof(this.Quantity));
            }
        }

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
        public Store Store { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
