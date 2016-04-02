using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeadphonePlayer
{
    class PlayerPresenter : IObserver<bool>
    {
        private PlayerView view;
        private bool prev;

        public PlayerPresenter()
        {
            view = new PlayerView();
            prev = false;
        }

        private void play()
        {
            view.Play();
        }

        private void pause()
        {
            view.Pause();
        }

        public void Update(bool on)
        {
            if (on)
            {
                play();
            }
            else
            {
                pause();
            }
        }

        public void OnNext(bool value)
        {
            if (prev != value)
            {
                Update(value);
            }
        }

        public void OnError(Exception error)
        {
            throw error;
        }

        public void OnCompleted()
        {
        }
    }
}
