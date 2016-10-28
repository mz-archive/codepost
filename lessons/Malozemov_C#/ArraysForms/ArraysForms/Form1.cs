using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysForms
{
    public partial class Form1 : Form
    {
        //---------------------------------
        int i;
        int count, sum;
        public int[] arr;
        //----------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e) //Кнопка "Создать"
        {
            sum = 0;
            string s = "";
            Random Rand = new Random();
            count = Convert.ToInt32(textBox1.Text);
            arr = new int[count];
            for (i = 0; i < count; i++)
            {
                arr[i] = Rand.Next(100);
                sum = sum + arr[i];
                s = s + arr[i].ToString() + " ";
            }

            richTextBox1.Clear();
            richTextBox1.AppendText(s);
            button4.Enabled = true;
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e) //Кнопка "Стандартное отклонение"
        {
            double So = 0;
            double SoResult = 0;
            double sr = sum / count;
            for (i = 0; i < count; i++)
            {
                So = So + (Math.Pow(arr[i] - sr, 2));
                
            }

            SoResult = Math.Sqrt(So/(count-1));
            richTextBox1.AppendText("\n-------------------------------------------------------------------------------");
            richTextBox1.AppendText("\nСтандартное отклонение = " + SoResult + "\n");
            richTextBox1.AppendText("-------------------------------------------------------------------------------");
        }

        private void button4_Click(object sender, EventArgs e) //Кнопка "Сортировать (Сортировка пузырьком - buble sort)"
        {
            {
                int temp = 0;
                for (i = 0; i < count; i++)
                {
                    for(int j = 0; j < count; j++)
                    {
                        if(arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                string s = "";
                for (i = 0; i < count; i++)
                {
                    s = s + arr[i] + " ";
                }
                richTextBox1.AppendText("\n-------------------------------------------------------------------------------");
                richTextBox1.AppendText("Результат сортировки:\n" + s + "\n");
                richTextBox1.AppendText("-------------------------------------------------------------------------------");
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e) //Сохранение отсортированного массива в файл "Сохранить"
        {
            var swrite = new StreamWriter("output.txt");
            for(i = 0; i < count; i++)
            {
                swrite.WriteLine(arr[i]);
            }
            swrite.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Считывание данных из файла и заполнение ими массива "Открыть"
        {
            var sread = new StreamReader("input.txt");
            sum = 0;
            count = 0;
            string s = "";
            arr = new int[100];
            for (i = 0; i < arr.Length; i++) 
            {
                arr[i] = 0;
            }
            while (!sread.EndOfStream)
            {
                    arr[count] = Convert.ToInt32(sread.ReadLine());
                    sum += arr[count];
                    s += Convert.ToString(arr[count]) + " ";
                    count++;
            }
            sread.Close();
            richTextBox1.Clear();
            richTextBox1.AppendText(s);
            button4.Enabled = true;
            button2.Enabled = false;
        }
        //----------------------------------------------------------------------------------------
    }
}
