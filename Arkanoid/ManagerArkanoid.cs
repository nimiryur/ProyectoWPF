using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid 
{ 
    class ManagerArkanoid : INotifyPropertyChanged

    {

        //public ObservableCollection<object> listaClasificados = new ObservableCollection<object>();

        //private AccDatos accData = new AccDatos();
        private Musica mpMusic = new Musica();
        private Musica mpSFX = new Musica();

        public Jugador player = new Jugador();
        public VentanaCarga VenCar { get; set; }
        public ManagerStackPanel ManSPanel { get; set; }

        public AccDatos AccData { get; set; }




        //CONSTRUCTOR
        public ManagerArkanoid()
        {
            VenCar = new VentanaCarga();
            ManSPanel = new ManagerStackPanel();
            AccData = new AccDatos();
       
            //hola que ase

            //listaClasificados.Add("1. Pedro 4656874526");
            //listaClasificados.Add("2. Pepe  37973131");

        }


            //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       
    }
}
