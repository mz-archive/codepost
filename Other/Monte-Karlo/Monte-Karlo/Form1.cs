using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monte_Karlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, в программу для расчета одномерных интегралов", "Welcome!");
        }

        // Объявление переменных как глобальных.
        public double k, p, s, x, Integral;
        public int n, i, a, b;


        private void button1_Click(object sender, EventArgs e)
        {
            s = 0;
            Integral = 0;

            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены, заполните все поля, пожалуйста!", "Внимание!");
            }
            else 
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                n = int.Parse(textBox3.Text);
                k = b - a;
                Random g = new Random();
                for (i = 1; i < n+1; i++) 
                {
                    /* 
                     
                     По умолчанию метод NextDouble генерирует числа 
                     в диапазоне от 0 до 1 как нам и надо
                     
                    */

                    x = a + g.NextDouble() * (b - a); // Получаем произвольную величину из [a;b]
                    s = s + (1 + x);                  //Функция, можно подставить любую
                    
                }
                textBox4.Text = s.ToString();
                Integral = (1.0 / n) * k * s;
                textBox5.Text = Integral.ToString();
                
            }
            
        }
    }
}
