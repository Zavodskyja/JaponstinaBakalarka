using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japonstina
{
    // Progressbar s pruhlednym pozadim
    public class TransparentProgressBar : Control
    {
        private int _value;
        private int _maximum;

        public TransparentProgressBar()

        {
            this.DoubleBuffered = true;
            this.Value = 0;
            this.Maximum = 100;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.BackColor = Color.Transparent;
        }

        public int Value
        {
            get { return _value; }
            set
            {
                _value = Math.Min(value, Maximum);
                Invalidate();
            }
        }

        public int Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            using (var bgBrush = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(bgBrush, ClientRectangle);
            }

            if (Value > 0)
            {
                var rect = new Rectangle(0, 0, (int)((float)Value / Maximum * Width), Height);

                using (var brush = new LinearGradientBrush(rect, ForeColor, ForeColor, LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }

            base.OnPaint(e);
        }
    }

    // Circle progressbar s pruhlednym pozadim
    public class CircularProgressBar2: Control
    {
        private int _value;
        private int _maximum;

        public CircularProgressBar2()
        {
            this.DoubleBuffered = true;
            this.Value = 0;
            this.Maximum = 100;
            this.Width = 100;
            this.Height = 100;
            this.ForeColor = Color.Red;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            
        }

        public int Value
        {
            get { return _value; }
            set
            {
                _value = Math.Min(value, Maximum);
                Invalidate(); // Force the control to redraw itself
            }
        }

        public int Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, Width, Height);
                e.Graphics.SetClip(path);

                // Draw background circle
                using (var bgBrush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillEllipse(bgBrush, new Rectangle(0, 0, Width - 1, Height - 1));
                }

                // Draw progress arc
                using (var progressBrush = new SolidBrush(ForeColor))
                {
                    float progressAngle = 360f * ((float)Value / Maximum);
                    e.Graphics.FillPie(progressBrush, new Rectangle(0, 0, Width - 1, Height - 1), -90, progressAngle);
                }
            }

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent != null)
            {
                int index = Parent.Controls.GetChildIndex(this);
                for (int i = Parent.Controls.Count - 1; i > index; i--)
                {
                    Control c = Parent.Controls[i];
                    if (c.Bounds.IntersectsWith(Bounds) && c.Visible)
                    {
                        using (var bmp = new Bitmap(c.Width, c.Height))
                        {
                            c.DrawToBitmap(bmp, c.ClientRectangle);
                            e.Graphics.TranslateTransform(c.Left - Left, c.Top - Top);
                            e.Graphics.DrawImageUnscaled(bmp, Point.Empty);
                            e.Graphics.TranslateTransform(Left - c.Left, Top - c.Top);
                        }
                    }
                }
            }
        }
}
}


