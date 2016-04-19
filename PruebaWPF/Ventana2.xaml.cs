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



        /************************************************************************************/
        /*                              metodos tactiles                                    */
        /************************************************************************************/

        /*
            wpf propone dos tipos de eventros cuando se produce un toque o entrada tactil, los 
            evenos de toque y los eventos de manipulacion, los primeros proporcionan los datos
            sin procesar de cada dedo en la pantalla tactil y su movimiento, los eventos de 
            manipulacion interpretan la entrada como acciones. Los eventos tactiles heredan de 
            las clases UIElement, UIElement3D y ContentElement

            Eventos tactiles o de toque 
                // propagacion
            * TouchDonw             -> se produce cuando un dedo toca la pantalla
            * TouchMove             -> se produce cuando un dedo se mueve por la pantalla
            * TouchUp               -> cuando un dedo se ha levantado de la pantalla
            * TouchEnter            -> cuando una entrada tactil se mueve de afuea hacia adentro (de un elemento)
            * TouchLeave            -> cuando una entrada tactil se mueve de adentro hacia afuera (de un elemento)
            * PreviewTouchDon       -> cuando un dedo toca la panta (tunelizacion)
            
            * GotTouchCapture       -> cuando un elemento captura una entrada tactil
            * LostTouchCapture      -> cuando un elemento pierde una entrada tactil

            // eventos de tunelizacion, son contraparte de los eventos de propagacion 
            // usand el prefijo Privie 
                * PreviweTouchMove
                * PreviewTouchUp
            
            al controlar estos ventros se puede conseguir la posicion de la entrara tactil relatica a cualquier 
            elemento con los metodos GetIntermediateTouchPoints, o GetTouchPoint
            
            vease  -> https://msdn.microsoft.com/es-es/library/ms754010(v=vs.100).aspx
            vease  -> https://msdn.microsoft.com/es-es/library/ms742806(v=vs.100).aspx
            

        */
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // cambiar de color los botones
            
        }

        // comenzar la manípulacion de la las formas 
        private void Window_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
        {
            e.ManipulationContainer = this;
            e.Handled = true;
        }

        // manipular el rectangulo, el evento delta se llama cuando se mueve el dedo por un dispositivo tactil o se levanta el dedo
        private void Window_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            Rectangle Rget = e.OriginalSource as Rectangle;
            Matrix RgetMatrix = ((MatrixTransform)Rget.RenderTransform).Matrix;

            /// rotar el rectangulo de creacion 
            RgetMatrix.RotateAt(e.DeltaManipulation.Rotation, e.ManipulationOrigin.X, e.ManipulationOrigin.Y);

            /// redimencionar el rectangulo
            RgetMatrix.ScaleAt(e.DeltaManipulation.Scale.X, e.DeltaManipulation.Scale.Y, e.ManipulationOrigin.X, e.ManipulationOrigin.Y);

            // mover el rectangulo
            RgetMatrix.Translate(e.DeltaManipulation.Translation.X, e.DeltaManipulation.Translation.Y);

            // aplicar los cambios al rectangulo
            Rget.RenderTransform = new MatrixTransform(RgetMatrix);

            Rect contenedor = new Rect( ( (FrameworkElement)e.ManipulationContainer).RenderSize );
            Rect formsLado = Rget.RenderTransform.TransformBounds(new Rect(Rget.RenderSize));

        }

        private void Window_ManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
        {
            // desaceleracion para la traslacion
            e.TranslationBehavior.DesiredDeceleration = 10.0 * 96.0 / (1000.0 * 1000.0);

            // desaceleracion para la expansion
            e.ExpansionBehavior.DesiredDeceleration = 0.1 * 96 / (1000.0 * 1000.0); ;

            // desaceleracion para la rotacion
            e.RotationBehavior.DesiredDeceleration = 720 / (1000.0 * 1000.0);

            e.Handled = true;
        }

        // crear un evento de toque para el econtrol canvzas
        private void MyEventoToque_TouchDown(object sender, TouchEventArgs e)
        {
            // mostrar mensajes cada que se toque el canvas 
            MessageBox.Show("SE HA TOCADO EL CANVAS", "TOCANDO", MessageBoxButton.OK, MessageBoxImage.Information);

            // crear puntos de toque
            TouchPoint PuntoToque = e.GetTouchPoint(this.LnsDibujo);
           
            Point tp = new Point(PuntoToque.Position.X, PuntoToque.Position.Y);

            Line linea = new Line();
            linea.X1 = tp.X;
            linea.Y1 = tp.Y;

            // meter en el canvas
            this.LnsDibujo.Children.Add(linea);


            


            
            
        }




        /************************************************************************************/
        /*                                    metodos variados                              */
        /************************************************************************************/
        private void Btn13_Click(object sender, RoutedEventArgs e)
        {
            Random Rgen = new Random();


            // generar linea a lo wey 
            for ( int i = 0; i < 5; i ++)
            {
             
                Line l = new Line();
                l.X1 = Rgen.Next(0, (int)this.Width);
                l.Y1 = Rgen.Next(0, (int)this.Width);

                l.X2 = Rgen.Next(0, (int)this.Width);
                l.Y2 = Rgen.Next(0, (int)this.Width);

                l.Stroke = Brushes.Red;
                l.StrokeThickness = 3;

                this.LnsDibujo.Children.Add(l);

            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            // cambiar el tipo de cursor 
            this.CambiarCursorCruz();

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            /* crear un rectangulo */
            Rectangle r1 = new Rectangle();
            r1.Name = "r1";
            r1.Width = 200;
            r1.Height = 300;
            r1.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            r1.Stroke = Brushes.Blue;
            r1.StrokeThickness = 3;
            this.LnsDibujo.Children.Add(r1);



        }


        // crear eventos propios para enlazarlos con el XAML
        private void MiClik_Click (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Un evento distinto", "Evento Propio", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LnsDibujo_TouchDown(object sender, TouchEventArgs e)
        {

        }
    }
}
