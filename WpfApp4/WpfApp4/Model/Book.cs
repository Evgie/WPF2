using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public class Book : EntityBase, ICloneable
    {
        public string Title { get; set; }

        public decimal Cost { get; set; }

        public DateTime Date { get; set; }

        public Book()
        {
            this.Date = DateTime.Now;
        }

        public object Clone()
        {
            return new Book
            {
                Title = this.Title,
                Cost = this.Cost,
                Date = this.Date,

                Id = this.Id,
                IsNew = this.IsNew
            };
        }

        public void EditBook(BookWindow bookWindow)
        {
            this.Title = bookWindow.newTitle.Text;
            this.Cost = Decimal.Parse(bookWindow.newCost.Text);
            this.Date = bookWindow.newDate.SelectedDate.Value;
        }
    }    
}
