using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid 
{ 
    class ManagerArkanoid : INotifyPropertyChanged

    {

        //private AccDatos accData = new AccDatos();
        private Musica mpMusic = new Musica();
        private Musica mpSFX = new Musica();
        public VentanaCarga VenCar { get; set; }
        public ManagerStackPanel ManSPanel { get; set; }




        //CONSTRUCTOR
        public ManagerArkanoid()
        {
            VenCar = new VentanaCarga();
            ManSPanel = new ManagerStackPanel();


        }


            //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       
    }
}
