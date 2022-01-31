using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace Arkanoid
{
    class VentanaCarga : INotifyPropertyChanged
    {
        DispatcherTimer timer = new DispatcherTimer();
        private string _textoCargando;
        public int Contador { get; set; }

        private int _y_pelota = 0;

        private int _angle_pelota = 0;
        private int _x_nave = 0;
        

        public int WidthWindow { get; set; }
        public int HeightWindow { get; set; }
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
        public int X_Nave
        {
            get
            {
                return this._x_nave;
            }

            set
            {
                this._x_nave = value;
                OnPropertyChanged();
            }
        }

        public int Y_Pelota
        {
            get
            {
                return this._y_pelota;
            }

            set
            {
                this._y_pelota = value;
                OnPropertyChanged();
            }
        }

        public int Angle_Pelota
        {
            get
            {
                return this._angle_pelota;
            }

            set
            {
                this._angle_pelota = value;
                OnPropertyChanged();
            }
        }

        

        public VentanaCarga(ref int widthWindow, ref int heightWindow)
        {
            WidthWindow =  widthWindow;
            HeightWindow = heightWindow;

            DispatcherTimer timer2 = new DispatcherTimer();

            TextoCargando = "Cargando";
            Contador = 0;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += delegate {
                TextoCargando = TextoCargando == "Cargando..." ? "Cargando" : TextoCargando += ".";
                Contador++;
                if (Contador == 20)
                {
                    timer.Stop();
                    timer2.Stop();
                }
            };
            timer.Start();

            bool haciaIzquierda = true;
            bool pelotaCayendo = true;
            
            timer2.Interval = TimeSpan.FromMilliseconds(10);
            X_Nave = 0;
            Y_Pelota = 0;
            timer2.Tick += delegate {
                int marginNave = WidthWindow / 3;
                int limiteIzquierda = -WidthWindow / 2 + marginNave;
                int limiteDerecha = WidthWindow / 2 - marginNave;
                if (haciaIzquierda)
                {
                    X_Nave -= 5;
                } else
                {
                    X_Nave += 5;
                }
                if (X_Nave <= limiteIzquierda)
                {
                    haciaIzquierda = false;
                } else if (X_Nave >= limiteDerecha)
                {
                    haciaIzquierda = true;
                }
                Angle_Pelota += 5;
                if (Y_Pelota <= - HeightWindow / 14  )
                {
                    pelotaCayendo = true;
                }
                else if (Y_Pelota >= HeightWindow / 2 - 30)
                {
                    pelotaCayendo = false;
                }
                if (pelotaCayendo)
                {
                    Y_Pelota += 5;
                } else
                {
                    Y_Pelota -= 5;
                }

            };
            timer2.Start();
           // TransformGroup myTransformGroup = new TransformGroup();

            //myTransformGroup.Children.Add(new TranslateTransform(x, y));
            //RotateTransform rt = new RotateTransform(angle, x, y);
            //myTransformGroup.Children.Add(rt);
            //this.img.RenderTransform = myTransformGroup;
        }


        //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
