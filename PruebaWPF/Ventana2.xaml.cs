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
    /// Interaction logic for Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {

        /************************************************************************************/
        /*                     metodos graficos para el raton                               */
        /************************************************************************************/
        private void CambiarCursorCruz()
        {
            Cursor CursorNuevo = Cursors.Cross;
            Mouse.OverrideCursor = CursorNuevo;
        }



        public Ventana2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // cambiar de color los botones
            
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            // cambiar el tipo de cursor 
            this.CambiarCursorCruz();

        }
    }
}
