using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // Содержит классы StreamReader и StreamWriter

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //общие данные класса
        int[] Массив; //дин.массив с отлож.инициал.
        int N = 0;//кол-во чисел
        int Sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = int.Parse(textBox1.Text);
            string s = " ";
            Массив = new int[N];//иниц.массива
            Random Rand = new Random();//обьявить переменную Rand
            //класса Random
            for (int i = 0; i < N; i++)
            {
                Массив[i] = Rand.Next(100);//случайное число
                s = s + Массив[i].ToString() + " ";
            }
            richTextBox1.Clear();
            richTextBox1.AppendText(s);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double Std = 0, z = 0;
            double Sr = Sum / N;

            for (int i = 0; i < N; i++)//сумма кв.откл.
                z = z + Math.Pow(Массив[i] - Sr, 2);

            Std = Math.Sqrt(z / (N - 1));
            richTextBox1.AppendText("Стандартное отклонение = " + Std); //Стандартное отклонение
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // сортировка массива
            int tmp;
            for (int j = 0; j < N - 1; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if (Массив[i + 1] > Массив[i])
                    {
                        tmp = Массив[i];
                        Массив[i] = Массив[i + 1];
                        Массив[i + 1] = tmp;

                    }
                }
            }

            string s = " ";//строковая переменная s
            for (int j = 0; j < N; j++)
            {
                s = s + Массив[j].ToString() + " ";//строка для вывода массива чисел
            }
            richTextBox1.AppendText("Сортировка массива = " + s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            StreamReader file_in = new StreamReader("datain.txt");
            Массив = new int[100];//иниц.наст.
            while (!file_in.EndOfStream)
            {
                Массив[i] = int.Parse(file_in.ReadLine());
                i++;
            }
            file_in.Close();//закрыть поток
            N = i;
            string s = " ";//строковая переменная s
            for (int j = 0; j < N; j++)
            {
                s = s + Массив[j].ToString() + " ";//строка для вывода массива чисел
            }
            richTextBox1.AppendText("Массив из файла = " + s);

        }
    }
}

