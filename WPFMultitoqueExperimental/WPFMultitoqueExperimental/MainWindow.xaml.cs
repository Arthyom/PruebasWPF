using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMultitoqueExperimental
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

        /// creacion de un evento para manejar el click del boton 
        public void myClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("haciendo Clisk");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // sin embargo tambien se pueden crear objetos desde el codigo de c#
            ListBox L1 = new ListBox();
            L1.Height = 50;
            L1.Width = 50;

            L1.Background = new SolidColorBrush(Color.FromArgb(194, 34, 23, 43));

            ListBoxItem it =  new ListBoxItem();
            ListBoxItem it2 = new ListBoxItem();
            ListBoxItem it3 = new ListBoxItem();

            it.Content = "hola";
            it2.Content = "adios";
            it3.Content = "bye";

            L1.Items.Add(it);
            L1.Items.Add(it2);
            L1.Items.Add(it3);

            L1.HorizontalAlignment = HorizontalAlignment.Left;
            this.grid.Children.Add(L1);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("oprimiendo el boton");
        }
    }
}
