using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDyplomowa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(GradientBackground);

            this.Invalidate();
        }

        private void GradientBackground(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle gradientRect = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRect, Color.FromArgb(0, 214, 136), Color.FromArgb(0, 83, 224), 1f);


            g.FillRectangle(b, gradientRect);
        }

    }
}
