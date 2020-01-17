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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Toy> toys;

        public MainWindow()
        {
            InitializeComponent();
            toys = new ObservableCollection<Toy>();
            this.gridToys.ItemsSource = toys;
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            this.toys.Add(new Toy { Id = Int32.Parse(this.toyId.Text), Item = this.toyItem.Text, Price = Decimal.Parse(this.toyPrice.Text), Quantity = Int32.Parse(this.toyQuantity.Text) });
        }

        private void OnRemoveClick(object sender, RoutedEventArgs e)
        {
            this.toys.RemoveAt(this.gridToys.SelectedIndex);
        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            this.toys.Clear();
        }
    }
}
