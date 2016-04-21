﻿using System;
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
using System.Windows.Ink;

namespace PruebaWPF
{
    /// <summary>
    /// Interaction logic for Ventana3.xaml
    /// </summary>
    public partial class Ventana3 : Window
    {

        Stroke TrazoTinta ;
        StylusPointCollection ColeccionStylus = new StylusPointCollection();
        Double AnchoLinea;

        public Ventana3()
        {
            InitializeComponent();
        }

        /* La clase inkcnvas representa un control habilitado para trazos, aunque no es un control propiamente visible en el panel
           toolbox, se puede instanciar mediante codigo C# o bien mediante XMAL, utilise un inkcanvas para capturar una entrata 
           manuscrita a partir de algun tipo de stylus, raton o dispositivo tactil, el inkcanvas funciona con una entrada definida
           por stylus, o algun objeto que emule a un stylus, dedo raton etc. 

           la propiedad stroke, permite establecer un trazo simple dentro del ink canvas, la propiedad stroke es una instancia 
           de la clase Stroke, tiene solo dos constructores los dos sobrecargados y ninguno por defecto, su constructor mas simple
           resive un punto definido por un stylus */

        // cargar los elementos necesarios en el formulario
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InkCanvas LiensoTinta = new InkCanvas();
            LiensoTinta.Background = Brushes.Black;
            

        }

        // generar lineas mientras se mueva el dedo sobre el panel tactil
        private void DibujarDedo_TouchMove ( object sender, MouseEventArgs e)
        {
            Cursor NuevoCursor = Cursors.Cross;
            Mouse.OverrideCursor = NuevoCursor;
            
            Point PuntoGenerico = e.GetPosition(this.LiensoTinta);
            StylusPoint PuntoToque = new StylusPoint(PuntoGenerico.X, PuntoGenerico.Y);
            this.ColeccionStylus.Add(PuntoToque);
        }

        // agregar el trazo al canvas en cuanto se suelte el raton
        private void InsertarTrazo (object sender, MouseButtonEventArgs e)
        {
            DrawingAttributes EstiloTrazo = new DrawingAttributes();
            EstiloTrazo.Color = Color.FromRgb(255, 255, 255);
            EstiloTrazo.Height = this.SldrGrosorTrazo.Value;
            EstiloTrazo.Width = this.SldrGrosorTrazo.Value;



            this.TrazoTinta = new Stroke(this.ColeccionStylus,EstiloTrazo);
            this.LiensoTinta.Strokes.Add(this.TrazoTinta);

            
        }

        // cambiar el color del trazo
        private void BtnCambiaColor_Click(object sender, RoutedEventArgs e)
        {

            this.LiensoTinta.Strokes.Clear();
            /*
            this.TrazoTinta.StylusPoints.Clear();
            this.ColeccionStylus.Clear();
            */
            
           
            
        }
    }
}
