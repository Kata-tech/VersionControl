using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Entities.Abstractions;

namespace WindowsFormsApp2.Entities
{
    public class Ball : Toy
    {
        public Ball()
        {
        AutoSize= false;
            Width= 50;
            Height = 50;
            Paint += Ball_Paint;

        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        public void MoveBall()
        {
            Left += 1;
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }
    }
}
