using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Arkanoid
{
    class VentanaCarga : INotifyPropertyChanged
    {
        DispatcherTimer timer = new DispatcherTimer();
        private string _textoCargando;
        public int Contador { get; set; }
        public string TextoCargando
        {
            get
            {
                return this._textoCargando;
            }

            set
            {
                this._textoCargando = value;                 
                OnPropertyChanged();
            }
        }


        public VentanaCarga()
        {
            TextoCargando = "Cargando";
            Contador = 0;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Cargando;
            timer.Start();


            
            
        }

        private void Cargando(object sender, EventArgs e)
        {
            if (TextoCargando == "Cargando...")
            {
                TextoCargando = "Cargando";
            }
            else
            {
                TextoCargando += ".";
            }
            Contador++;
            if (Contador==7)
            {
               
            }
        }


        //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
