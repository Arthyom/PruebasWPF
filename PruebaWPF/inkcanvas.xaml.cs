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
using System.Windows.Shapes;

namespace PruebaWPF
{
    /// <summary>
    /// Interaction logic for inkcanvas.xaml
    /// </summary>
    public partial class inkcanvas : Window
    {
        public inkcanvas()
        {
            InitializeComponent();
        }

        // definir un evento de click
        private void MyClick ( object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hola mundo!!!");

            // intentar vaciar los controles creados via xml
            lst1.Items.Clear();

            
        }
    }
}
