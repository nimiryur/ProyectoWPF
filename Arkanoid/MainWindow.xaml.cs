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
using System.Windows.Threading;

namespace Arkanoid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ManagerArkanoid mArk = new ManagerArkanoid();

        // HELOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        // porque sere tan inutil :(
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mArk;
            //DataContext = Prueba;
            //tb_Nick.Text = mArk.AccData.EjecutarProcedimiento("Prueba", null).ToString();
            //comboxElegirTamWindow.
        }

        private void comboxElegirTamWindow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] newDimension = comboxElegirTamWindow.SelectedItem.ToString().Split(ConfigPantalla.SEPARATOR_WIDTH_HEIGHT);
            mArk.ConfPantalla.WidthWindow = Int32.Parse(newDimension[0]);
            mArk.ConfPantalla.HeightWindow = Int32.Parse(newDimension[1]);
            MessageBox.Show(comboxElegirTamWindow.Text);
        }

        private void spAjustes_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void BtnCambiarAvatar(object sender, RoutedEventArgs e)
        {
            mArk.ConfPantalla.ActualAvatar = getFileNameBtn(ref sender);
        }

        private void BtnCambiarNave(object sender, RoutedEventArgs e)
        {
            mArk.ConfPantalla.ActualNave = getFileNameBtn(ref sender);
        }
        private void BtnCambiarEscenario(object sender, RoutedEventArgs e)
        {
            mArk.ConfPantalla.ActualEscenario = getFileNameBtn(ref sender);
        }
        
        private string getFileNameBtn(ref object sender)
        {
            Button button = (Button)sender;
            Image image = button.FindName("image") as Image;
            string cadena = ReverseString(image.Source.ToString());
            cadena = cadena.Split("/")[0];
            cadena = ReverseString(cadena);
            return cadena;
        }

        public string ReverseString(string cadena)
        {
            string nuevaCadena = "";
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                nuevaCadena += cadena[i];
            }
            return nuevaCadena;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Window window = sender as Window;
            //if (mArk.ManSPanel.SpCarga == ManagerStackPanel.VISIBLE)
            //{
            //    window.WindowStyle = WindowStyle.None;
            //   // window.Width = 200;
            //   // window.Width = 200;
            //} else
            //{
            //    window.WindowStyle = WindowStyle.SingleBorderWindow;
            //   // window.ResizeMode = ResizeMode.CanResize;
            //}

            mArk.ConfPantalla.WidthWindow = (int) window.ActualWidth;
            mArk.ConfPantalla.HeightWindow = (int) window.ActualHeight;

            mArk.VenCar.WidthWindow = (int)window.ActualWidth;
            mArk.VenCar.HeightWindow = (int)window.ActualHeight;
        }
        //GetClasificacion

    }
}
