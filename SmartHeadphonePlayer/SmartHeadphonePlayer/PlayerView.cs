using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHeadphonePlayer
{
    class PlayerView
    {
        private PlayerComponent component;
        private HeadphoneMonitor monitor;

        public PlayerView()
        {
            component = new PlayerComponent();
            component.AddCheckChanged(PlayerComponent_DetectingChanged);
            component.OnComponentExit(PlayerComponent_OnExit);
            monitor = new HeadphoneMonitor();
            component.Show();
        }

        public bool DetectingHeadphones
        {
            get { return component.HeadphonesDetecting; }
        }

        public void Play()
        {
            component.Play();
            SetState(true);
        }

        public void Pause()
        {
            component.Pause();
            SetState(false);
        }

        public void SetState(bool value)
        {
            monitor.Invoke(new Action(() => { monitor.SetState(value); }));
        }

        public void PlayerComponent_OnExit(object sender, FormClosingEventArgs e)
        {
            monitor.Close();
            Application.Exit();
        }

        public void PlayerComponent_DetectingChanged(object sender, EventArgs e)
        {
            if(component.HeadphonesDetecting)
            {
                monitor.Show();
            }
            else
            {
                monitor.Hide();
            }
        }


        public void Log(string line)
        {
            monitor.Invoke(new Action(() => { monitor.AddLog(line); }));
        }
    }
}
