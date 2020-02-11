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
using Task2.Models;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new StoreContext())
            {
                //var product = context.Product.Find(15);
                //product.Name = "OOO";
                var product = new Product
                {                    
                    Type = "AHHA",
                    Name = "MyProduct"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
