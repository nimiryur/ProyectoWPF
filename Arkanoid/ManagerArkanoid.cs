using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Arkanoid 
{ 
    class ManagerArkanoid : INotifyPropertyChanged

    {

        private double _volume;
        private bool _mouseCaptured = false;

        public double Volume
        {
            get { return _volume; }
            set
            {
                _volume = value;
                OnPropertyChanged("Volume");
            }
        }
             
        public bool MouseCaptured
        {
            get { return _mouseCaptured; }
            set
            {
                _mouseCaptured = value;
                OnPropertyChanged("MouseCaptured");
            }
        }


        //public ObservableCollection<object> listaClasificados = new ObservableCollection<object>();

        //private AccDatos accData = new AccDatos();

        //private Musica mpSFX = new Musica();

        public Jugador player = new Jugador();


        public Musica MpMusic { get; set; }
        public VentanaCarga VenCar { get; set; }
        public ManagerStackPanel ManSPanel { get; set; }

        public AccDatos AccData { get; set; }




        //CONSTRUCTOR
        public ManagerArkanoid()
        {
            VenCar = new VentanaCarga();
            ManSPanel = new ManagerStackPanel();
            AccData = new AccDatos();
            MpMusic = new Musica();
          

            //listaClasificados.Add("1. Pedro 4656874526");
            //listaClasificados.Add("2. Pepe  37973131");

        }



        


        //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       
    }
}
