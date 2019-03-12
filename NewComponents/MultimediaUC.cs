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
        private uint minutes;
        private uint seconds;
        private string timeStamp;
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

        [Category("Appearance")]
        [Description("Valor de las primeras dos cifras del tiempo en formato (MM:SS)")]
        public uint Minutes
        {
            set
            {
                if (value < 99)
                {
                    this.minutes = value;
                }
                else
                {
                    this.minutes = 0;
                }
                timeStamp = string.Format("{0,2}:{1,2}", this.minutes, this.seconds);
            }
            get
            {
                return this.minutes;
            }
        }


        [Category("Appearance")]
        [Description("Valor de las últimas dos cifras del tiempo en formato (MM:SS)")]
        public uint Seconds
        {
            set
            {
                if (value < 60)
                {
                    this.seconds = value;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    this.seconds = value % 60;
                }
                timeStamp = string.Format("{0,2}:{1,2}", this.minutes, this.seconds);
            }
            get
            {
                return this.seconds;
            }
        }

        [Category("Behaviour")]
        [Description("Evento que se lanza cuando Seconds supera un valor de 60")]
        public event EventHandler DesbordaTiempo;

        public MultimediaUC()
        {
            InitializeComponent();
            Resize += MultimediaUC_OnResize;
            this.playImage = Properties.Resources.play;
            this.pauseImage = Properties.Resources.pause;
            this.Minutes = 0;
            this.Seconds = 0;
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

        protected override void OnSizeChanged(EventArgs e)
        {
            this.btnPlayPause.Location = new Point(3, 3);
            this.btnPlayPause.Size = new Size(this.ClientSize.Width - 3, this.ClientSize.Width - 3);
            this.lblTimestamp.Location = new Point(this.Width / 2 - this.lblTimestamp.Width / 2, this.btnPlayPause.Location.Y + this.btnPlayPause.Height + 3);
            this.Size = new Size(this.Width, this.btnPlayPause.Height + this.lblTimestamp.Height + 10);
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
