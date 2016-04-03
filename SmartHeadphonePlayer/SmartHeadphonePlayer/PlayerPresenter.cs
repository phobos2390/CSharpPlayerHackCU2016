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
            prev = true;
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
            if (view.DetectingHeadphones && prev != value)
            {
                Update(value);
                view.Log("Setting play state to " + value);
            }
            view.SetState(value);
            prev = value;
        }

        public void OnError(Exception error)
        {
            view.Log(error.Message);
        }

        public void OnCompleted()
        {
        }
    }
}
