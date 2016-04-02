using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHeadphonePlayer
{
    class PlayerView
    {
        private PlayerComponent component;

        public PlayerView()
        {
            component = new PlayerComponent();
            component.Show();
        }

        public void Play()
        {
            component.Play();
        }

        public void Pause()
        {
            component.Pause();
        }
    }
}
