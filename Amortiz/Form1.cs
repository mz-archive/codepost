using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Amortiz
{
    public partial class Form1 : Form
    {
        public int SPI, method;
        public double StartPrice, NB, AvansPlat;
		
		//SPI - срок полезного использования целочисленный в месяцах(поэтому умножаем при расчете на 12)
		//method - способ расчета, номер(индекс) выбранного элемента в combobox, может быть линейный или уеньшаемого остатка
		//StartPrice - введенная стартовая(начальная) цена (переменная с плавающей точкой
		// NB - налоговая база
		//AvansPlat - авансовый платеж
		
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      

        }

        private void button1_Click(object sender, EventArgs e) //событие при нажатии на кнопку
        {
            if ((textBox1.Text == "") || (textBox2.Text == "")) // проверяется все ли данные введены (|| - означает или, можно писать OR)
            {
                MessageBox.Show("Вы не ввели исходные данные!", "Внимание!"); //выводится сообщение если данные не введены
            }
            else //идет расчет если данные введены
            {
                method = comboBox1.SelectedIndex; //Из textBox-ов присваиваются строки приобразуются в переменные
                SPI = Convert.ToInt32(textBox1.Text) * 12; //Перевод в месяцы
                StartPrice = Convert.ToDouble(textBox2.Text); 

                // 0 - линейный
                // 1 - уменьшаемого остатка


                

                if (method == 0) // проверка на выбранный метод
                {
					//идут расчеты и результаты конвертируются в строки и выводятся в textBox-ы

                    textBox3.Text = Convert.ToString(StartPrice / SPI);
                    textBox4.Text = textBox3.Text;
                    textBox5.Text = textBox3.Text;
                    textBox8.Text = "0";
                    textBox7.Text = StartPrice.ToString();
                    textBox6.Text = Convert.ToString(StartPrice - (StartPrice / SPI));
                    textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) - (StartPrice / SPI));
                    NB = (Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox6.Text)) / 4;
                    textBox10.Text = NB.ToString();
                    textBox11.Text = (NB * 2.2 / 100).ToString();
                }
                else//аналогично только с другим методом
                {
                    textBox3.Text = ((StartPrice * 3) / SPI).ToString();
                    textBox8.Text = StartPrice.ToString();
                    textBox7.Text = (StartPrice - Convert.ToDouble(textBox3.Text)).ToString();
                    textBox4.Text = (Convert.ToDouble(textBox7.Text) * 3 / SPI).ToString();
                    textBox6.Text = (Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox4.Text)).ToString();
                    textBox5.Text = (Convert.ToDouble(textBox6.Text) * 3 / SPI).ToString();
                    textBox9.Text = (Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox5.Text)).ToString();
                    NB = (Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox6.Text)) / 4;
                    textBox10.Text = NB.ToString();
                    textBox11.Text = (NB * 2.2 / 100).ToString();
                }
 
            }
            
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //событие если пользователь выбирает другой способ
        {
			//все textBox-ы очищаются (им просто присваиваются пустые строки)
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
          
        }
    }
}
