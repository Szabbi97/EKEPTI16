using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_CantorSet
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Yellow, 3);

        public Form1()
        {
            InitializeComponent();
        }

        private void Cantor(int level, PointF p1, PointF p2)
        {
            if (level == 1)
            {
                g.DrawLine(p, p1, p2);
            }
            else
            {
                PointF ph1 = new PointF(
                    (2 * p1.X + p2.X) / 3,
                    (2 * p1.Y + p2.Y) / 3);
                PointF ph2 = new PointF(
                    (p1.X + 2 * p2.X) / 3,
                    (p1.Y + 2 * p2.Y) / 3);

                Cantor(level - 1, p1, ph1);
                Cantor(level - 1, ph2, p2); 
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            PointF p1 = new PointF(20, canvas.Height / 2);
            PointF p2 = new PointF(canvas.Width - 20, canvas.Height / 2);

            Cantor(sb_Level.Value, p1, p2);
        }

        private void sb_Level_ValueChanged(object sender, EventArgs e)
        {
            lbl_Level.Text = "Level: " + sb_Level.Value;
            canvas.Refresh();
        }
    }
}
