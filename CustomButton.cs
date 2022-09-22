using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ClockIn
{
    public class CustomButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.White;
        
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.LightGray;
            this.ForeColor = Color.White;
        }
        
        protected override void OnPaint(PaintEventArgs prevent)
        {
            base.OnPaint(prevent);
            prevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);
        }
    }
}
