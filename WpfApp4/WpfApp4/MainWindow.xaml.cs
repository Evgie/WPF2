using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4.Model;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Author> authors;

        public MainWindow()
        {
            InitializeComponent();
            authors = new ObservableCollection<Author>
            {
                new Author
                {
                    FirstName = "Mark",
                    LastName = "Twain",
                    BirthDate = new DateTime(1835,11,30),
                    Country = Countries.GetCountry(0),
                    Language = Languages.GetLanguage(0),
                    PlaceOfBirth = "Florida, Missouri",
                    IsNew = false,
                    Books = new ObservableCollection<Book>
                    {
                        new Book{ Title = "NewBook", Date = DateTime.Now, Cost = 10m, IsNew = false, Language = Languages.GetLanguage(1), IsRead = true }
                    }
                }
            };
            this.DataContext = authors;
            this.language.ItemsSource = Languages.languagesList;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "btnNewAuthor":    // Add NewAuthor.
                    AddAuthor();
                    break;
                case "menuNewAuthor":    // Add NewAuthor.
                    AddAuthor();
                    break;
                case "btnBookNew":  // Add NewBook.
                    AddBook();
                    break;
                case "menuNewBook":  // Add NewBook.
                    AddBook();
                    break;
            }
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "menuNewAuthor":
                        e.CanExecute = true;
                        break;
                    case "menuNewBook":
                        if (this.authorList.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                }
            }
            else if (e.Source is Button)
            {
                Button btn = e.Source as Button;
                switch (btn.Name)
                {
                    case "btnNewAuthor":
                        e.CanExecute = true;
                        break;
                    case "btnBookNew":
                        if (this.authorList.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                }
            }
        }

        private void AddBook()
        {
            Book book = new Book();
            BookWindow bookWindow = new BookWindow() { DataContext = book };
            bookWindow.ShowDialog();

            if (!bookWindow.DialogResult.Value)
                return;
            else
            {
                Author author = new Author();
                author = (Author)this.authorList.SelectedItem;
                author.AddNewBook(this.authors[this.authorList.SelectedIndex].Books, bookWindow);
            }
        }

        private void AddAuthor()
        {
            Author author = new Author();
            var authorWindow = new AuthorWindow() { DataContext = author };
            authorWindow.newLanguage.ItemsSource = Languages.languagesList;
            authorWindow.newCountry.ItemsSource = Countries.countriesList;
            authorWindow.ShowDialog();

            if (!authorWindow.DialogResult.Value)
                return;
            else
                author.AddNewAuthor(this.authors, authorWindow);
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selectedAuthor = this.authorList.SelectedItem as Author;
            if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "menuRemoveAuthor":
                        this.authors.Remove(selectedAuthor);
                        break;
                    case "menuRemoveBook":
                        var selectedBook = this.booksDataGrid.SelectedItem as Book;
                        selectedAuthor.Books.Remove(selectedBook);
                        break;
                }
            }
            else if (e.Source is Button)
            {
                Button btn = e.Source as Button;
                switch (btn.Name)
                {
                    case "btnDeleteAuthor":
                        this.authors.Remove(selectedAuthor);
                        break;

                    case "btnBookDelete":
                        var selectedBook = this.booksDataGrid.SelectedItem as Book;
                        selectedAuthor.Books.Remove(selectedBook);
                        break;
                }
            }
        }

        private void DeleteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "menuRemoveAuthor":
                        if (this.authorList.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                    case "menuRemoveBook":
                        if (this.booksDataGrid.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                }
            }
            else if (e.Source is Button)
            {
                Button btn = e.Source as Button;
                switch (btn.Name)
                {
                    case "btnDeleteAuthor":
                        if (this.authorList.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                    case "btnBookDelete":
                        if (this.booksDataGrid.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                }
            }
        }

        private void ChangeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "menuEditAuthor":
                        ChangeAuthor();
                        break;
                    case "menuEditBook":
                        ChangeBook();
                        break;
                }
            }
            else if (e.Source is Button)
            {
                Button btn = e.Source as Button;
                switch (btn.Name)
                {
                    case "btnChangeAuthor":
                        ChangeAuthor();
                        break;
                    case "btnBookChange":
                        ChangeBook();
                        break;
                }
            }
        }

        private void ChangeAuthor()
        {
            Author author = new Author();
            Author initialAuthor = new Author();
            var authorWindow = new AuthorWindow() { DataContext = this.authorList.SelectedItem };
            author = (Author)this.authorList.SelectedItem;
            initialAuthor = (Author)author.Clone();
            authorWindow.newLanguage.ItemsSource = Languages.languagesList;
            authorWindow.newCountry.ItemsSource = Countries.countriesList;
            authorWindow.ShowDialog();

            if (authorWindow.DialogResult.Value)
            {
                this.authorList.Items.Refresh();
            }
            else
            {
                this.authors[this.authorList.SelectedIndex] = initialAuthor;
                this.authorList.Items.Refresh();
                return;
            }
        }

        private void ChangeBook()
        {
            Book book = new Book();
            Book initialBook = new Book();
            var bookWindow = new BookWindow() { DataContext = this.booksDataGrid.SelectedItem };
            book = (Book)this.booksDataGrid.SelectedItem;
            initialBook = (Book)book.Clone();
            bookWindow.ShowDialog();

            if (!bookWindow.DialogResult.Value)
            {
                this.authors[this.authorList.SelectedIndex].Books[this.booksDataGrid.SelectedIndex] = initialBook;
                return;
            }
        }

        private void ChangeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Source is MenuItem)
            {
                MenuItem menuItem = e.Source as MenuItem;
                switch (menuItem.Name)
                {
                    case "menuEditAuthor":
                        if (this.authorList.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                    case "menuEditBook":
                        if (this.booksDataGrid.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                }
            }
            else if (e.Source is Button)
            {
                Button btn = e.Source as Button;
                switch (btn.Name)
                {
                    case "btnChangeAuthor":
                        if (this.authorList.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                    case "btnBookChange":
                        if (this.booksDataGrid.SelectedItem is null)
                        {
                            e.CanExecute = false;
                            return;
                        }
                        e.CanExecute = true;
                        break;
                }
            }
        }
    }
}

