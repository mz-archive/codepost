using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Finisar.SQLite;

namespace BanksApp
{
    public partial class BanksForm : Form
    {
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        

        public string opt_Bank;
        public double opt_Period, opt_CostOfMonth, m;
        


        public double my_Salary, my_Costs, my_Credit, my_Period, my_freeMoney;

        public string[] bank_names = new string[10];
        public double[] bank_percents = new double[10];
        public double[] bank_pay = new double[10];
        public int bank_ball;

        public BanksForm()
        {
            InitializeComponent();
            sqlite_conn = new SQLiteConnection("Data Source=banks.db;Version=3;New=False;Compress=True;");
            sqlite_conn.Open();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM ListOfBanks ORDER BY Percent DESC LIMIT 5;";
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    dGV_TOP.Rows.Add(
                        sqlite_datareader["Bank"].ToString(),
                        sqlite_datareader["Percent"].ToString(),
                        sqlite_datareader["Rating"].ToString()
                        );
                }

            sqlite_conn.Close();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CorrBank_Click(object sender, EventArgs e)
        {
            int i;
            i = -1;
            /*
            
            
            
            while (pBar.Value < 100)
            {
                pBar.Value += 1;

            }

            
            
            */

            if (checkBox1.Checked)
            {
               
                MessageBox.Show("Применяется подбор с учетом надежности по балу доверия", "Алгоритм с доверием");
                
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Заполните пожалуйста все поля!", "Поля не заполнены!");
                }
                else
                {
                    pBar.Value = 0;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                               
                    
                  
                    
                    //Алгоритм подбора с учетом доверия(надежности)
                    my_Salary = Convert.ToDouble(textBox1.Text);
                    my_Period = Convert.ToDouble(textBox2.Text);
                    my_Costs = Convert.ToDouble(textBox3.Text);
                    my_Credit = Convert.ToDouble(textBox4.Text);
                    my_freeMoney = my_Salary - my_Costs;

                    bank_ball = comboBox1.SelectedIndex + 1;
                    
                   
                    
                    sqlite_conn = new SQLiteConnection("Data Source=banks.db;Version=3;New=False;Compress=True;");

                    sqlite_conn.Open();

                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM ListOfBanks WHERE Rating >= "+bank_ball+";";
                    sqlite_datareader = sqlite_cmd.ExecuteReader();

                    while (sqlite_datareader.Read())
                    {
                        i++;
                        bank_names[i] = sqlite_datareader["Bank"].ToString();
                        bank_percents[i] = double.Parse(sqlite_datareader["Percent"].ToString());
                        m = bank_percents[i] / 12 / 100;
                        bank_pay[i] = my_Credit * (m * Math.Pow(1 + m, my_Period)) / ((Math.Pow(1 + m, my_Period) - 1));

                        while (pBar.Value < 100)
                        {
                            pBar.Value += 1;

                        }
                    }

                    sqlite_conn.Close();


                    double min = double.MaxValue;
                    int incValue, payValue;
                    incValue = -1;
                    payValue = 0;

                    foreach (var j in bank_pay)
                    {



                        incValue++;
                        if ((j < min) && (j != 0) && (j <= my_freeMoney))
                        {
                            min = j;
                            payValue = incValue;

                        }

                    }

                    if (min > my_freeMoney)
                    {
                        MessageBox.Show("Оптимальный банк не найден, попробуйте увеличить срок или сократить сумму мин расходов", "Внимание!");
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }
                    else
                    {
                        opt_Bank = bank_names[payValue];
                        opt_Period = my_Period;
                        opt_CostOfMonth = bank_pay[payValue];
                        textBox5.Text = opt_Bank.ToString();
                        textBox6.Text = opt_Period.ToString();
                        textBox7.Text = opt_CostOfMonth.ToString();
                    }

                    i = -1;
                    foreach (var j in bank_pay)
                    {
                        i++;
                        bank_pay[i] = 0;
                        bank_names[i] = "";

                    }
                   
                }

            }
            else
            {

                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Заполните пожалуйста все поля!", "Поля не заполнены!");
                }
                else
                {
                    pBar.Value = 0;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    //Алгоритм подбора
                    my_Salary = Convert.ToDouble(textBox1.Text);
                    my_Period = Convert.ToDouble(textBox2.Text);
                    my_Costs = Convert.ToDouble(textBox3.Text);
                    my_Credit = Convert.ToDouble(textBox4.Text);
                    my_freeMoney = my_Salary - my_Costs;

                    sqlite_conn = new SQLiteConnection("Data Source=banks.db;Version=3;New=False;Compress=True;");

                    sqlite_conn.Open();

                        sqlite_cmd = sqlite_conn.CreateCommand();
                        sqlite_cmd.CommandText = "SELECT * FROM ListOfBanks;";
                        sqlite_datareader = sqlite_cmd.ExecuteReader();

                        while (sqlite_datareader.Read())
                        {
                            i++;                                                                       
                            bank_names[i] = sqlite_datareader["Bank"].ToString();
                            bank_percents[i] = double.Parse(sqlite_datareader["Percent"].ToString());
                            m = bank_percents[i]/12/100;
                            bank_pay[i] = my_Credit * (m * Math.Pow(1 + m, my_Period)) / ((Math.Pow(1 + m, my_Period)-1));
                            while (pBar.Value < 100)
                            {
                                pBar.Value += 1;

                            }
                                
                        }

                    sqlite_conn.Close();

                    
                    double min = double.MaxValue;
                    int incValue, payValue;
                    incValue = -1;
                    payValue = 0;

                    foreach(var j in bank_pay)
                    {
                        
                        
                        
                        incValue++;
                        if ((j < min) && (j != 0) && (j <= my_freeMoney)) 
                        {
                            min = j;
                            payValue = incValue;
 
                        }
                        
                    }

                    if (min > my_freeMoney)
                    {
                        MessageBox.Show("Оптимальный банк не найден, попробуйте увеличить срок или сократить сумму мин расходов", "Внимание!");
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }
                    else 
                    {
                        opt_Bank = bank_names[payValue];
                        opt_Period = my_Period;
                        opt_CostOfMonth = bank_pay[payValue];
                        textBox5.Text = opt_Bank.ToString();
                        textBox6.Text = opt_Period.ToString();
                        textBox7.Text = opt_CostOfMonth.ToString();
                    }

                    i = -1;
                    foreach (var j in bank_pay)
                    {
                        i++;
                        bank_pay[i] = 0;
                        bank_names[i] = "";

                    }
                    
                    
                    
                }
            }
           
        }

        private void btn_BankList_Click(object sender, EventArgs e)
        {
            Bank_List f2 = new Bank_List();
            f2.Show();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                label8.Enabled = true;

            }
            else 
            {
                comboBox1.Enabled = false;
                label8.Enabled = false;
            }
        }



    }
}
