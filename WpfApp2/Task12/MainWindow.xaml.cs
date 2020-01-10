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

namespace Task12
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

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "Button9":
                    this.textBlock.Text = "9";
                    break;
                case "Button8":
                    this.textBlock.Text = "8";
                    break;
                case "Button7":
                    this.textBlock.Text = "7";
                    break;
                case "Button6":
                    this.textBlock.Text = "6";
                    break;
                case "Button5":
                    this.textBlock.Text = "5";
                    break;
                case "Button4":
                    this.textBlock.Text = "4";
                    break;
                case "Button3":
                    this.textBlock.Text = "3";
                    break;
                case "Button2":
                    this.textBlock.Text = "2";
                    break;
                case "Button1":
                    this.textBlock.Text = "1";
                    break;
                case "Button0":
                    this.textBlock.Text = "0";
                    break;
                case "ButtonC":
                    this.textBlock.Text = "";
                    break;
            }
            e.Handled = true;
        }
    }
}
