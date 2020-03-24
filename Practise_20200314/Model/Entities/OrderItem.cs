using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.Entities
{
    public class OrderItem : INotifyPropertyChanged
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
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

        private decimal listPrice;
        public decimal ListPrice
        {
            get
            {
                return this.listPrice;
            }
            set
            {
                if (this.listPrice == value)
                    return;

                this.listPrice = value;
                this.OnPropertyChanged(nameof(this.ListPrice));
            }
        }

        private byte discount;
        public byte Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                if (this.discount == value)
                    return;

                this.discount = value;
                this.OnPropertyChanged(nameof(this.Discount));
            }
        }

        private Order order;
        public Order Order
        {
            get
            {
                return this.order;
            }
            set
            {
                if (this.order == value)
                    return;

                this.order = value;
                this.OnPropertyChanged(nameof(this.Order));
            }
        }

        public Product Product { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
