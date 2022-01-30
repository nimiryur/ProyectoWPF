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
    class ManagerStackPanel : INotifyPropertyChanged
    {
        DispatcherTimer timer = new DispatcherTimer();
        private string _spCarga;

        private const string VISIBLE = "Visible";
        private const string HIDDEN = "Hidden";

        public string SpCarga
        {
            get
            {
                return this._spCarga;
            }

            set
            {
                this._spCarga = value;
                OnPropertyChanged();
            }
        }

        //CONSTRUCTOR
        public ManagerStackPanel()
        {
            SpCarga = HIDDEN;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += delegate { SpCarga = HIDDEN; timer.Stop(); };
            timer.Start();
        }



        //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
