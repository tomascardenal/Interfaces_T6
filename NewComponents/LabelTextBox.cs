using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewComponents
{
    public enum ePosition
    {
        LEFT, RIGHT
    }

    [
        DefaultProperty("TextLbl"),
        DefaultEvent("Load")
    ]

    public partial class LabelTextBox : UserControl
    {
        private ePosition position = ePosition.LEFT;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosition Position
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosition), value))
                {
                    position = value;
                    this.Refresh();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }

            get
            {
                return position;
            }
        }

        private int separation = 0;
        [Category("Design")]
        [Description("Píxels de separación entre Label y TextBox")]
        public int Separation
        {
            set
            {
                if (value >= 0)
                {
                    separation = value;
                    this.Refresh();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separation;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            this.Refresh();
        }
        
        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            switch (position)
            {
                case ePosition.RIGHT:
                    //Location of txt component
                    txt.Location = new Point(0, 0);
                    //Width of textbox
                    txt.Width = this.Width - lbl.Width - Separation;
                    //Position of label
                    lbl.Location = new Point(txt.Width + Separation, 0);
                    break;
                case ePosition.LEFT:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separation, 0);
                    txt.Width = this.Width - lbl.Width - Separation;
                    break;
            }
            //Height of component
            this.Height = Math.Max(txt.Height, lbl.Height);
            e.Graphics.DrawLine(new Pen(Color.Violet), lbl.Left, this.Height - 1, lbl.Left + lbl.Width, this.Height - 1);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
