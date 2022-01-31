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
    class ConfigPantalla : INotifyPropertyChanged
    {
        public int _widthWindow = 800;

        public int _heightWindow = 450;

        private ObservableCollection<string> _changeWidthHeight;

        public const string SEPARATOR_WIDTH_HEIGHT = " * ";

        public const string RUTA_AVATARES = "/Images/Avatar/";
        public const string RUTA_NAVES = "/Images/Naves/";
        public const string RUTA_ESCENARIOS = "/Images/Escenario/";

        private ObservableCollection<string> _avatars;

        private ObservableCollection<string> _naves;

        private ObservableCollection<string> _escenarios;

        private string _actualAvatar = null;
        private string _actualNave = null;
        private string _actualEscenario = null;

        public string ActualAvatar
        {
            get { return RUTA_AVATARES + _actualAvatar; }
            set
            {
                _actualAvatar = value;
                OnPropertyChanged();
            }
        }
        public string ActualNave
        {
            get { return RUTA_NAVES + _actualNave; }
            set
            {
                _actualNave = value;
                OnPropertyChanged();
            }
        }
        public string ActualEscenario
        {
            get { return RUTA_ESCENARIOS + _actualEscenario; }
            set
            {
                _actualEscenario = value;
                OnPropertyChanged();
            }
        }
        //public int[] 

        //public ConfigPantalla()
        //{
        //    Values = new ObservableCollection<string[]> {
        //        new string[]
        //        {
        //            "False", "20 * 2"
        //        },
        //        new string[]
        //        {
        //            "True", "20 * 2"
        //        }
        //    };
        //}


        public ObservableCollection<string> ChangeWidthHeight
        {
            get { return _changeWidthHeight; }
            set {
                _changeWidthHeight = value;
            }
        }
        public ObservableCollection<string> Avatars
        {
            get { return _avatars; }
            set
            {
                _avatars = value;
            }
        }
        public ObservableCollection<string> Naves
        {
            get { return _naves; }
            set
            {
                _naves = value;
            }
        }
        public ObservableCollection<string> Escenarios 
        {
            get { return  _escenarios; }
            set
            {
                _escenarios = value;
            }
        }
        public ConfigPantalla()
        {
            ChangeWidthHeight = new ObservableCollection<string>()
            {
                WidthHeightString(800, 450),
                WidthHeightString(400, 225),
                WidthHeightString(700, 300)
            };
            Avatars = new ObservableCollection<string>()
            {
                RUTA_AVATARES + "pollo.png",
                RUTA_AVATARES + "chico.png",
                RUTA_AVATARES + "chica_rosa.png",
                RUTA_AVATARES + "ninja_azul.png",
                RUTA_AVATARES + "ninja_rojo.png",
                RUTA_AVATARES + "tortuga.png"
            };
            Naves = new ObservableCollection<string>()
            {
                RUTA_NAVES + "nave1.png",
                RUTA_NAVES + "nave2.png",
                RUTA_NAVES + "nave3.png",
                RUTA_NAVES + "nave4.png"
            };
            Escenarios = new ObservableCollection<string>()
            {
                RUTA_ESCENARIOS + "fondo1.png",
                RUTA_ESCENARIOS + "fondo2.png",
                RUTA_ESCENARIOS + "fondo3.png",
                RUTA_ESCENARIOS + "fondo4.png",
                RUTA_ESCENARIOS + "fondo5.png",
            };
            ActualNave = "nave1.png";
        }

        private string WidthHeightString(int w, int h)
        {
            return w + SEPARATOR_WIDTH_HEIGHT + h;
        }

        public int WidthWindow
        {
            get
            {
                
                return this._widthWindow;
            }

            set
            {
                this._widthWindow = value;
                OnPropertyChanged();
            }
        }
        public int HeightWindow
        {
            get
            {
                return this._heightWindow;
            }
            set
            {
                this._heightWindow = value;
                OnPropertyChanged();
            }
        }

        public string SizeWindow
        {
            get
            {
                return WidthWindow + " x " + HeightWindow;
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
