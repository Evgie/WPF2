using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public class Author : EntityBase, ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Country { get; set; }

        public string Language { get; set; }

        public string PlaceOfBirth { get; set; }

        public ObservableCollection<Book> Books { get; set; }

        public Author()
        {
            this.BirthDate = DateTime.Now;
            this.Books = new ObservableCollection<Book>();
        }

        public object Clone()
        {
            return new Author
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                BirthDate = this.BirthDate,
                Country = this.Country,
                Language = this.Language,
                PlaceOfBirth = this.PlaceOfBirth,
                Books = this.Books,
                Id = this.Id,
                IsNew = this.IsNew
            };
        }

        public override string ToString()
        {
            string s = this.FirstName + " " + this.LastName;
            return s.ToString();
        }

        public void AddNewAuthor(ObservableCollection<Author> authors, AuthorWindow authorWindow)
        {
            this.EditAuthor(authorWindow);

            if (this.FirstName != "" && this.LastName != "" && this.BirthDate != null && this.Country != "" && this.Language != "" && this.PlaceOfBirth != "")
                authors.Add(this);
            this.Save();
        }

        public void EditAuthor(AuthorWindow authorWindow)
        {
            this.FirstName = authorWindow.newFirstName.Text;
            this.LastName = authorWindow.newLastName.Text;
            this.BirthDate = authorWindow.newDateOfBirth.SelectedDate.Value;
            this.Country = (string)authorWindow.newCountry.SelectedValue;
            this.Language = (string)authorWindow.newLanguage.SelectedValue;
            this.PlaceOfBirth = authorWindow.newPlaceOfBirth.Text;
        }

        public void AddNewBook(ObservableCollection<Book> Books, BookWindow bookWindow)
        {
            Book book = new Book();
            book.EditBook(bookWindow);
            Books.Add(book);
            book.Save();
        }
    }
}
