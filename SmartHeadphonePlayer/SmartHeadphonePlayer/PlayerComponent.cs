using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace SmartHeadphonePlayer
{
    public partial class PlayerComponent : Form
    {
        bool fileSelected;

        public PlayerComponent()
        {
            fileSelected = false;
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        public AxWMPLib.AxWindowsMediaPlayer Player
        {
            get { return player; }
            set { player = value; }
        }

        public void Play()
        {
            if(fileSelected)
            {
                Player.Ctlcontrols.play();
            }
        }

        public void Pause()
        {
            if (fileSelected)
            {
                Player.Ctlcontrols.pause();
            }
        }

        private void Player_MediaError(object sender, _WMPOCXEvents_MediaErrorEvent e)
        {
            MessageBox.Show("Cannot play media file.\nError: " + e.pMediaObject);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if(videoFileSelector.ShowDialog() == DialogResult.OK)
            {
                fileSelected = true;
                Player.URL = videoFileSelector.FileName;
                Play();
            }
        }
    }
}
