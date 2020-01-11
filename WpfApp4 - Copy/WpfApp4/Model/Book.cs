using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public class Book : EntityBase
    {
        public string Title { get; set; }

        public decimal Cost { get; set; }

        public DateTime Date { get; set; }

        
        public void EditBook(BookWindow bookWindow)
        {
            this.Title = bookWindow.newTitle.Text;
            this.Cost = Decimal.Parse(bookWindow.newCost.Text);
            this.Date = bookWindow.newDate.SelectedDate.Value;
        }

        public void AddNewBook(ObservableCollection<Book> books, BookWindow bookWindow)
        {
            this.EditBook(bookWindow);

            if (this.Title != "" && this.Cost != 0 && this.Date != null)
                books.Add(this);
            this.Save();
        }
    }
}
