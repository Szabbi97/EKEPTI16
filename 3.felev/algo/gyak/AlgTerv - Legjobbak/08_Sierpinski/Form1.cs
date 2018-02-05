using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Sierpinski
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush b = Brushes.DarkOliveGreen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sierpinski(int level, PointF[] points)
        {
            if (level == 1)
            {
                g.FillPolygon(b, points);
            }
            else
            {
                PointF pf1 = new PointF(
                    (points[0].X + points[1].X) / 2,
                    (points[0].Y + points[1].Y) / 2);
                PointF pf2 = new PointF(
                    (points[0].X + points[2].X) / 2,
                    (points[0].Y + points[2].Y) / 2);
                PointF pf3 = new PointF(
                    (points[1].X + points[2].X) / 2,
                    (points[1].Y + points[2].Y) / 2);

                Sierpinski(level - 1, new PointF[] { points[0], pf1, pf2 });
                Sierpinski(level - 1, new PointF[] { pf1, points[1], pf3 });
                Sierpinski(level - 1, new PointF[] { pf2, pf3, points[2] });
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            PointF p1 = new PointF(canvas.Width / 2, 20);
            PointF p2 = new PointF(20, canvas.Height - 20);
            PointF p3 = new PointF(canvas.Width - 20, canvas.Height - 20);

            Sierpinski(hScrollBar1.Value, new PointF[] { p1, p2, p3 });
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            lbl_Level.Text = "Level: " + hScrollBar1.Value;
            canvas.Refresh();
        }
    }
}
