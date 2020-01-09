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
                        new Book{ Title="NewBook", Date= DateTime.Now, Cost=10m, IsNew=false }
                    }
                }
            };
            this.DataContext = authors;            
        }
                
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //
            //AuthorWindow
            //
            Author author = new Author();
            var authorWindow = new AuthorWindow() { DataContext = author };
            authorWindow.Owner = this;
            authorWindow.newLanguage.ItemsSource = Languages.languagesList;
            authorWindow.newCountry.ItemsSource = Countries.countriesList;
            authorWindow.ShowDialog();
            author.AddNewAuthor(this.authors, authorWindow);

            //
            //BookWindow
            //
            //Author author = new Author();
            //author = (Author)this.authorList.SelectedItem;
            //var authorWindow = new AuthorWindow() { DataContext = this.authorList.SelectedItem };
            //Book book = new Book();
            //BookWindow bookWindow = new BookWindow() { DataContext = book};
            //bookWindow.Owner = this;
            //bookWindow.ShowDialog();
            //book.AddNewBook(author.Books, bookWindow);

            //bookWindow.DataContext = this.booksDataGrid.SelectedItem;
            //FrameworkElement feSource = e.Source as FrameworkElement;
            //switch(feSource.Name)
            //{
            //    case "btnNewAuthor":
            //        authorWindow.Show();
            //        break;
            //    case "btnBookNew":
            //        bookWindow.Show();
            //        break;
            //}
        }

        

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void DeleteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void ChangeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //
            //AuthorChange
            //
            //Author author = new Author();
            //var authorWindow = new AuthorWindow() { DataContext = this.authorList.SelectedItem };
            //authorWindow.newLanguage.ItemsSource = Languages.languagesList;
            //authorWindow.newCountry.ItemsSource = Countries.countriesList;
            //authorWindow.Owner = this;            
            //authorWindow.ShowDialog();

            //author.EditAuthor(authorWindow);

            //
            //BookChange
            //
            var bookWindow = new BookWindow() { DataContext = this.booksDataGrid.SelectedItem };
            
        }

        private void ChangeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(this.authorList.SelectedItem is null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = true;
        }
    }
}
