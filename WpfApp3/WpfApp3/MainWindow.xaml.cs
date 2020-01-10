using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Control_MouseEnter(object sender, RoutedEventArgs e)
        {
            FrameworkElement feElement = e.Source as FrameworkElement;
            Debug.WriteLine($"MouseEnter: source {e.Source} sender {sender}");
        }

        private void Control_MouseDown(object sender, RoutedEventArgs e)
        {
            FrameworkElement feElement = e.Source as FrameworkElement;
            Debug.WriteLine($"MouseDown: source {e.Source} sender {sender}");
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feElement = e.Source as FrameworkElement;
            Debug.WriteLine($"Click: source {e.Source} sender {sender}");
            if (!(e.Source is CheckBox))
            {
                for (int i = 0; i < 3; i++)
                {
                    Button btn = new Button() { Content = $"Button {i}", Margin = new Thickness(10) };
                    myStackPanel.Children.Add(btn);
                    btn.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.OnClickPresssed));
                }
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickPresssed(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = Brushes.Red;
            e.Handled = true;
        }
    }
    public class BrushColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
            }
            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
