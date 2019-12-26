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

namespace Task2_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string FirstName = "Vasya";
            string LastName = "Pupkin";
            bool IsMaster = true;
            this.textBox1.DataContext = FirstName;
            this.textBox2.DataContext = LastName;
            this.checkBox.DataContext = IsMaster;
        }
    }
}
