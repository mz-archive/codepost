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
    public partial class Form1 : Form
    {
        /*int   i, niz;
        double y, f, n, sum, sh, verh;
        string s; */

        public int n;
        public double a, b, h;
        public string s;

        static int Nfun = 0; // Для select
        public static double Func(double x) 
        {
            switch(Nfun)
            {
                case 0:
                    return 1 / (1 + x * x);
                    
                case 1:
                    return (Math.Pow(x, 2) - 4 * x) / Math.Pow((x + 2), 2);
                    

                default:
                    return 1 / (1 + x * x);
            }
                
        }

        public static double IntFunc(double x)
        {
            switch (Nfun)
            {
                case 0:
                    return Math.Atan(x);
                    
                case 1:
                    return (Math.Pow(x, 2) - 4 * x) / Math.Pow((x + 2), 2);
                    

                default:
                    return Math.Atan(x);
            }

        }
        
        public Form1()
        {
            InitializeComponent();
            listBox1.SetSelected(0, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Выбор
        {
            Nfun = listBox1.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e) //Загрузка формы
        {

                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            int i;
            double s1 = 0; // результат интегрирования для левых
            double s2 = 0; // результат интегрирования для средних
            double s3 = 0; // результат интегрирования для трапеций
            double s4 = 0; // результат интегрирования для парабол
            double x = 0;

            n = Convert.ToInt32(textBox1.Text);
            a = Convert.ToInt32(textBox2.Text);
            b = Convert.ToInt32(textBox3.Text);

            h = (b - a) / n; // кол-во шагов
            richTextBox2.AppendText("\n Y  =  " + listBox1.Text + "   шаг интегрирования " 
                            + h + ", нижняя граница =" + a + ", верхняя граница = " + b);


            x = a;
            double z = IntFunc(b) - IntFunc(a); // для погрешности
            for (i = 0; i < n; i++ )
            {
                s1 = s1 + h * Func(x);
                x = x + h;
            }

            richTextBox2.AppendText("\n------------------------------------Результат---------------------------------");
            richTextBox2.AppendText("\n Метод левых прямоугольников = " + s1.ToString("F12") + 
                " Погрешность: " + Math.Abs(z-s1).ToString("F12"));
            //Метод средних
            for (i = 0; i < n; i++)
            {
                s2 = s2 + h * Func(x + h/2);
                x = x + h;
            }

            
            richTextBox2.AppendText("\n Метод средних прямоугольников = " + s2.ToString("F12") +
                " Погрешность: " + Math.Abs(z - s2).ToString("F12"));
            //Метод трапеций
            for (i = 0; i < n; i++)
            {
                s3 = s3 + (h /2) * (Func(x) + Func(x+h)); //S трапеции
                x = x + h;
            }
            richTextBox2.AppendText("\n Метод трапеций = " + s3.ToString("F12") +
                " Погрешность: " + Math.Abs(z - s3).ToString("F12"));

            //Метод Парабол
            for (i = 0; i < n; i++)
            {
                s4 = s4 + (h/6) * (Func(x) + 4*Func(x + h/2) + Func(x+h));// считаем.....
                x = x + h;
            }
            richTextBox2.AppendText("\n Метод парабол = " + s4.ToString("F12") +
                " Погрешность: " + Math.Abs(z - s4).ToString("F12"));

           /* s = "";
            y = 0;
            sum = 0;
            f = 0;
            
            sh = Int32.Parse(textBox1.Text);
            niz = Int32.Parse(textBox2.Text);
            verh = Int32.Parse(textBox3.Text);
            n = (verh - niz) / sh;
            

            

            if (listBox1.SelectedIndex == 0)
            {
                while( sum != verh )
                {
                    sum = sum + n;
                    y = 1 / (1 + Math.Pow(n, 2));
                    //f = f + (y * n);
                    f = f + y;
                    s = Convert.ToString(f);
                    richTextBox2.Clear();
                    richTextBox2.AppendText("Правило левых прямоугольников = " + s);

                }
                

            }
            else 
            {
                richTextBox2.Clear();
                richTextBox2.AppendText("Правило левых прямоугольников = " + s);
            } 
            */
            
            

        }

        private void button2_Click(object sender, EventArgs e) //График
        {
            Form2 f = new Form2();
            f.Xmin = (float)numericUpDown1.Value;
            f.Xmax = (float)numericUpDown2.Value;
            a = (float)numericUpDown1.Value;
            b = (float)numericUpDown2.Value;
            f.ShowDialog();

        }
    }
}
