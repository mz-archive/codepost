using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Integral_2010
{
    public partial class Form2 : Form
    {
        public float Xmin, Xmax;
        float x, dx = 0.1f, x1, x2, x0, y0;
        float y, y1, y2;
        float mx, my;
        int w, h;

        public Form2()
        {
            InitializeComponent();

        }

        public void GrData()
        {
            h = ClientSize.Height;
            w = ClientSize.Width;
            ////////////////////////////////
            float Ymax, Ymin;
            Ymin = Ymax = (float)Form1.Func(Xmin);
            x = Xmin;

            while(x <= Xmax)
            {
                y = (float)Form1.Func(x);
                if (y < Ymin) Ymin = y;
                if (y > Ymax) Ymax = y;
                x = x + dx;

            }

            // Масштаб вычисляем мы
            mx = (float)(w / Math.Abs(Xmax - Xmin));
            my = (float)(h / Math.Abs(Ymax - Ymin));

            x0 = -Xmin * mx;
            y0 = -Ymin * my;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics; //область для рисования
            GrData();
            gr.Clear(Color.White);//fon
            Pen pen = new Pen(Color.Black);
            pen.Width = 2; // karandash tolshina 
            x1 = Xmin;
            y1 = (float)Form1.Func(x1);

            while (x1 <= Xmax) 
            {
                x2 = x1 + dx;
                y2 = (float)Form1.Func(x2);
                gr.DrawLine(pen, x1 * mx + x0, h - (y1 * my + y0), x2 * mx + x0, h - (y2 * my + y0));
                x1 = x1 + dx;
                y1 = y2;

            }

        }
    }
}
