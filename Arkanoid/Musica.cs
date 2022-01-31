using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Arkanoid
{
    
    class Musica : INotifyPropertyChanged
    {
        private MediaPlayer _musicPlayer;
        public MediaPlayer MusicPlayer
        {
            get
            {
                return this._musicPlayer;
            }

            set
            {
                this._musicPlayer = value;
                OnPropertyChanged();
            }
        }
        public Musica()
        {
            MusicPlayer = new MediaPlayer();
            MusicPlayer.Open(new Uri("Music/mixkit-lust-966.mp3", UriKind.Relative));
            //MusicPlayer.Play();
           
        }

        public void Play()
        {
            MusicPlayer.Play();
        }


        //EVENTOS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
