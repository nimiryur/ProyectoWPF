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
        private string _spLogin;
        private string _spRegistro;
        private string _spClasificacion;
        private string _spMenu;
        private string _spAjustes;
        private string _spCreditos;
        private string _btnVolverAtras;

        private string _windowStyle;

        public const string VISIBLE = "Visible";
        public const string HIDDEN = "Hidden";

        public string WindowStyle
        {
            get
            {
                
                return this._windowStyle;
            }

            set
            {
                this._windowStyle = value;
                OnPropertyChanged();
            }
        }

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

        public string SpLogin
        {
            get
            {
                return this._spLogin;
            }
            set
            {
                this._spLogin = value;
                OnPropertyChanged();
            }
        }

        public string SpRegistro
        {
            get
            {
                return this._spRegistro;
            }

            set
            {
                this._spRegistro = value;
                OnPropertyChanged();
            }
        }

        public string SpClasificacion
        {
            get
            {
                return this._spClasificacion;
            }

            set
            {
                this._spClasificacion = value;
                OnPropertyChanged();
            }
        }

        public string SpMenu
        {
            get
            {
                return this._spMenu;
            }

            set
            {
                this._spMenu = value;
                OnPropertyChanged();
            }
        }

        public string SpAjustes
        {
            get
            {
                return this._spAjustes;
            }

            set
            {
                this._spAjustes = value;
                OnPropertyChanged();
            }
        }

        public string SpCreditos
        {
            get
            {
                return this._spCreditos;
            }

            set
            {
                this._spCreditos = value;
                OnPropertyChanged();
            }
        }

        public string BtnVolverAtras
        {
            get
            {
                return this._btnVolverAtras;
            }
            set
            {
                this._btnVolverAtras = value;
                OnPropertyChanged();
            }
        }

        //CONSTRUCTOR
        public ManagerStackPanel()
        {
            WindowStyle = "None";
            HideSps();
            SpCarga = VISIBLE;
            timer.Interval = TimeSpan.FromMilliseconds(20 * 1000);
            timer.Tick += delegate { 
                HideSps();
                SpLogin = VISIBLE;
                timer.Stop();
                WindowStyle = "SingleBorderWindow";
            };
            timer.Start();
        }

        private void HideSps()
        {
            SpCarga = HIDDEN;
            SpLogin = HIDDEN;
            SpRegistro = HIDDEN;
            SpClasificacion = HIDDEN;
            SpMenu = HIDDEN;
            SpAjustes = HIDDEN;
            SpCreditos = HIDDEN;
        }

        //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
