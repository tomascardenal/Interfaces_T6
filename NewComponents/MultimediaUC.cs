using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NewComponents
{
    public partial class MultimediaUC : UserControl
    {
        private bool playing = false;
        private Image playImage, pauseImage;

        [Category("Behaviour")]
        [Description("Informa de si este botón multimedia está activo")]
        public bool Playing
        {
            set
            {
                if (this.playing != value)
                {
                    playing = value;
                    togglePlayPause();
                }
            }
            get
            {
                return playing;
            }
        }

        public MultimediaUC()
        {
            InitializeComponent();
            Resize += MultimediaUC_OnResize;
            this.playImage = Properties.Resources.play;
            this.pauseImage = Properties.Resources.pause;
        }

        private void togglePlayPause()
        {
            if (playing)
            {
                this.btnPlayPause.BackgroundImage = pauseImage;
            }
            else
            {
                this.btnPlayPause.BackgroundImage = playImage;
            }
        }


        protected void MultimediaUC_OnResize(object sender, EventArgs e)
        {
            this.Height = this.Width + 10;
        }

        

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            this.Playing = !Playing;
            this.OnClick(e);
        }
    }
}
