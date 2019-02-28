using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewComponents
{
    public partial class MultimediaPlayer : Control
    {
        private Rectangle btnRect;
        private Rectangle[] pauseRects;
        private PointF[] trianglePoints;
        private bool drawPause = false;
        private Label lbTimer;



        public MultimediaPlayer()
        {
            InitializeComponent();
            this.Height = 80;
            this.Width = 80;
            RelocateComponents();

        }

        protected void RelocateComponents()
        {
            btnRect = new Rectangle(10, 10, this.Width - 20, this.Width - 20);
            PointF[] tp = { new PointF(20, 20), new PointF(20, btnRect.Bottom - 10), new PointF(btnRect.Right - 10, btnRect.Bottom - btnRect.Height / 2) };
            trianglePoints = tp;

            Rectangle[] pr = { new Rectangle(btnRect.Left + 15, btnRect.Top + 10, btnRect.Width / 6, btnRect.Height - 20), new Rectangle(btnRect.Right - btnRect.Width / 6- 15, btnRect.Top + 10, btnRect.Width / 6, btnRect.Height - 20) };
            pauseRects = pr;

            lbTimer = new Label();
            lbTimer.Location = new Point(10, 75);
            lbTimer.ClientSize = new Size(60, 20);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            //Button rectangle
            g.DrawRectangle(new Pen(new SolidBrush(Control.DefaultBackColor)), btnRect);
            g.FillRectangle
            (
                new LinearGradientBrush
                (
                    new Point(btnRect.Left, btnRect.Top),
                    new Point(btnRect.Right, btnRect.Bottom),
                    Color.LightBlue, Color.LightGray
                ),
                btnRect
            );

            if (drawPause)//Pause
            {
                g.FillRectangle(new SolidBrush(this.ForeColor), pauseRects[0]);
                g.FillRectangle(new SolidBrush(this.ForeColor), pauseRects[1]);
            }
            else//Play
            {
                g.FillPolygon(new SolidBrush(this.ForeColor), trianglePoints);
            }
            g.Dispose();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (btnRect.Contains(e.Location))
            {
                drawPause = !drawPause;
                base.OnMouseClick(e);
                Refresh();
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            RelocateComponents();
            Refresh();
        }
    }
}
