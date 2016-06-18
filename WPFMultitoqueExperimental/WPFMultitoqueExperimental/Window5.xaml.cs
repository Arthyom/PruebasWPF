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
using System.Windows.Shapes;

namespace WPFMultitoqueExperimental
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {

        // guardar las imagenes que hayan sido creadas para cada uno de los puntos de toue
        Dictionary<TouchDevice, Image> MarcasGuardadas = new Dictionary<TouchDevice, Image>();

        public Window5()
        {
            InitializeComponent();
        }


        // sobreescribir el metodo de toque 
        protected override void OnTouchDown(TouchEventArgs e)
        {
            base.OnTouchDown(e);

            // capturar el evento de toque para el evento indicado 
            this.cnv1.CaptureTouch(e.TouchDevice);

            // crear una nueva imagen para un nuevo toque 
            Image MarcaDedo = new Image { Source = new BitmapImage( new Uri(@"C:\Users\frodo\Pictures\Nueva carpeta\pencil-icon.png")) };

            // mover la imagen al punto de toque
            TouchPoint PuntoToque = e.GetTouchPoint(this.cnv1);
            MarcaDedo.RenderTransform = new TranslateTransform(PuntoToque.Position.X, PuntoToque.Position.Y);

            // guardar los objetos de toque y agregarlos al canvas 
            this.MarcasGuardadas[e.TouchDevice] = MarcaDedo;
            this.cnv1.Children.Add(MarcaDedo);
        }

        // sobreescribir el metodo touchmove
        protected override void OnTouchMove(TouchEventArgs e)
        {
            base.OnTouchMove(e);

            // ver si se ha tocad el canvas 
            if ( e.TouchDevice.Captured == this.cnv1)
            {
                Image MarcaDedo = this.MarcasGuardadas[e.TouchDevice];
                TranslateTransform transform =
                    MarcaDedo.RenderTransform as TranslateTransform;

                // mover a la locacion
                TouchPoint PuntoToque = e.GetTouchPoint(this.cnv1);
                transform.X = PuntoToque.Position.X;
                transform.Y = PuntoToque.Position.Y;

            }
        }

        // sobreescribir el metodo touchup
        protected override void OnTouchUp(TouchEventArgs e)
        {
            base.OnTouchUp(e);

            this.cnv1.ReleaseTouchCapture(e.TouchDevice);

            // quitar las imagenes del canvas y del diccionario
            this.cnv1.Children.Remove(this.MarcasGuardadas[e.TouchDevice]);
            this.MarcasGuardadas.Remove(e.TouchDevice);
        }
    }
}
