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
             
            //tb_Nick.Text = mArk.AccData.EjecutarProcedimiento("Prueba", null).ToString();
        }

        
       
        //GetClasificacion


    }
}
