using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DvumerArray
{
    public partial class Form1 : Form
    {
        //----------------------------------------
        int i, j, countS, countC;
        string s;
        public int[,] arr, arrTransp;
        bool flag;
        //----------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //button3.Enabled = false;
            button4.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // кнопка - "Вывести"
        {

            countS = Convert.ToInt32(numericUpDown1.Value) + 1;
            countC = Convert.ToInt32(numericUpDown2.Value) + 1;
            s = "";
            arr = new int[countS, countC];
            Random vast = new Random();
            if (radioButton1.Checked == true) 
            {
                for (i = 1; i < countS; i++) // Случайный массив 
                {
                    for (j = 1; j < countC; j++)
                    {
                        arr[i, j] = vast.Next(101) - 50;
                        if (j == countC - 1)
                        {
                            s = s + arr[i, j] + "\n\n";
                            //s = s + i + "." + j + " = " + arr[i, j] + "\n";
                        }
                        else
                        {
                            s = s + arr[i, j] + "      ";
                        }
                    }
                }
                richTextBox1.Clear();
                richTextBox1.AppendText(s);
            }
            else if (radioButton2.Checked == true) 
            {
                richTextBox1.Clear();
                s = "";
                for (i = 1; i < countS; i++ )
                {
                    for (j = 1; j < countC; j++)
                    {
                        arr[i, j] = i * j;
                        s = s + arr[i, j] + "      ";
                    }
                    s = s + " \n";
                    
                }
                    
                    richTextBox1.AppendText(s);
            
            }

            

            flag = false;
                                                               
        }

        private void button2_Click(object sender, EventArgs e) //Транспонировать
        {
            richTextBox1.Clear();
            s = "";
            arrTransp = new int[countC, countS];
            for (i = 1; i < countS; i++) 
            {
                for (j = 1; j < countC; j++)
                {
                    arrTransp[j, i] = arr[i, j];
                    
                }
            }

            for (i = 1; i < countC; i++)
            {
                for (j = 1; j < countS; j++)
                {
                    if (j == countS - 1)
                    {
                        s = s + arrTransp[i, j] + "\n\n";
                    }
                    else 
                    {
                        s = s + arrTransp[i, j] + "      "; 
                    }

                }
            }
            flag = true;
            richTextBox1.AppendText("---------------------------------------------------------------------------------------\n");
            richTextBox1.AppendText("ТРАНСПОНИРОВАННАЯ\n");
            richTextBox1.AppendText("---------------------------------------------------------------------------------------\n");
            richTextBox1.AppendText(s);


        }

        private void button3_Click(object sender, EventArgs e) //Сумма по столбцам
        {
            s = "";
            int sum, str, col;
            sum = 0;
            str = countC; // Для arrTransp строки
            col = countS; // Для arrTransp столбцы
            if (flag == false)
            {
                for (j = 1; j < countC; j++)
                {
                    for (i = 1; i < countS; i++)
                    {
                        sum = sum + arr[i, j];
                        if (i == countS - 1) 
                        {
                            s = s + sum + "     ";
                            sum = 0;
                        }
                    }
                }

            }
            else 
            {
                for (j = 1; j < col; j++)
                {
                    for (i = 1; i < str; i++)
                    {
                        sum = sum + arrTransp[i, j];
                        if (i == str - 1)
                        {
                            s = s + sum + "     ";
                            sum = 0;
                        }
                    }
                }
 
            }
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText(s + "\n");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e) // Минимум по строкам
        {
            s = "";
            int min, str, col;
            str = countC; // Для arrTransp строки
            col = countS; // Для arrTransp столбцы
            if (flag == false)
            {
                for (i = 1; i < countS; i++) 
                {
                    min = arr[i, 1];
                    for (j = 1; j < countC; j++) 
                    {
                        
                        if (min > arr[i, j]) min = arr[i, j];
                        if (j == countC - 1) s = s + i + " строка = " + min + "  \n";
                    }
                }
            }
            else 
            {
                for (i = 1; i < str; i++)
                {
                    min = arrTransp[i, 1];
                    for (j = 1; j < col; j++)
                    {

                        if (min > arrTransp[i, j]) min = arrTransp[i, j];
                        if (j == col - 1) s = s + i + " строка = " + min + "  \n";
                    }
                }

            }
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText("Минимум по строкам\n");
            richTextBox1.AppendText(s);
           

        }
    }
}
