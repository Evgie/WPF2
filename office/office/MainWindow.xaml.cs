using System;
using System.Collections.Generic;
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

namespace office
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

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch(feSource.Name)
            {
                case "YesButton":
                    MessageBox.Show("Button Yes");
                    break;
                case "NoButton":
                    MessageBox.Show("Button No");
                    break;
                case "CancelButton":
                    MessageBox.Show("Button Cancel");
                    break;
            }
            e.Handled = true;
        }
    }
}
