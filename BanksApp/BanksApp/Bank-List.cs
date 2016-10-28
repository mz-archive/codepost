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
    public partial class Bank_List : Form
    {
        BanksForm BF = new BanksForm();
        public string inp_bank;
        public string inp_percent;
        public int inp_rating;
        

        public Bank_List()
        {
            InitializeComponent();
            BF.sqlite_conn = new SQLiteConnection("Data Source=banks.db;Version=3;New=False;Compress=True;");

            BF.sqlite_conn.Open();

                BF.sqlite_cmd = BF.sqlite_conn.CreateCommand();
                BF.sqlite_cmd.CommandText = "SELECT * FROM ListOfBanks;";
                BF.sqlite_datareader = BF.sqlite_cmd.ExecuteReader();
                
                while(BF.sqlite_datareader.Read())
                {
                    dGV_MAIN.Rows.Add(
                        BF.sqlite_datareader["Bank"].ToString(), 
                        BF.sqlite_datareader["Percent"].ToString(),
                        BF.sqlite_datareader["Rating"].ToString()
                        );
                }

            BF.sqlite_conn.Close();
            
            
        }

        private void btn_AddNewBank_Click(object sender, EventArgs e)
        {

            //Проверка
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Заполните все поля!", "Внимание!");
            }
            else
            {
                inp_bank = textBox1.Text;
                inp_percent = textBox2.Text;
                inp_rating = Convert.ToInt32(textBox3.Text);

                BF.sqlite_conn.Open();

                    BF.sqlite_cmd = BF.sqlite_conn.CreateCommand();
                    BF.sqlite_cmd.CommandText = "INSERT INTO ListOfBanks(Bank, Percent, Rating) VALUES('" + inp_bank + "'," + inp_percent + "," + inp_rating + ");";
                    BF.sqlite_cmd.ExecuteNonQuery();

                BF.sqlite_conn.Close();

                dGV_MAIN.Rows.Clear(); //Очищаем, чтобы при обновлении не было повторов!

                /* Обновление dGV_MAIN =>>*/

                BF.sqlite_conn.Open();

                    BF.sqlite_cmd = BF.sqlite_conn.CreateCommand();
                    BF.sqlite_cmd.CommandText = "SELECT * FROM ListOfBanks;";
                    BF.sqlite_datareader = BF.sqlite_cmd.ExecuteReader();

                    while (BF.sqlite_datareader.Read())
                    {
                        dGV_MAIN.Rows.Add(
                            BF.sqlite_datareader["Bank"].ToString(),
                            BF.sqlite_datareader["Percent"].ToString(),
                            BF.sqlite_datareader["Rating"].ToString()
                            );
                    }

                BF.sqlite_conn.Close();

                /* Конец обновления */

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                MessageBox.Show("Банк " + inp_bank + " был добавлен в Базу Данных.", "Банк успешно добавлен!");
            }

            

           

           

        }

        private void btn_DeleteBank_Click(object sender, EventArgs e)
        {
            //Проверка
            if (textBox4.Text == "")
            {
                MessageBox.Show("Введите название банка, который хотите удалить!", "Внимание!");
            }
            else
            {
                //Название банка для удаления
                inp_bank = textBox4.Text;

                BF.sqlite_conn.Open();

                BF.sqlite_cmd = BF.sqlite_conn.CreateCommand();
                BF.sqlite_cmd.CommandText = "DELETE FROM ListOfBanks WHERE Bank='" + inp_bank + "';";
                BF.sqlite_cmd.ExecuteNonQuery();

                BF.sqlite_conn.Close();

                dGV_MAIN.Rows.Clear(); //Очищаем, чтобы при обновлении не было повторов!

                /* Обновление dGV_MAIN =>>*/

                BF.sqlite_conn.Open();

                    BF.sqlite_cmd = BF.sqlite_conn.CreateCommand();
                    BF.sqlite_cmd.CommandText = "SELECT * FROM ListOfBanks;";
                    BF.sqlite_datareader = BF.sqlite_cmd.ExecuteReader();

                    while (BF.sqlite_datareader.Read())
                    {
                        dGV_MAIN.Rows.Add(
                            BF.sqlite_datareader["Bank"].ToString(),
                            BF.sqlite_datareader["Percent"].ToString(),
                            BF.sqlite_datareader["Rating"].ToString()
                            );
                    }

                BF.sqlite_conn.Close();

                /* Конец обновления */

                textBox4.Clear();

                MessageBox.Show("Банк с названием " + inp_bank + " был удален.", "Банк успешно удален!");
 
            }
            
        }

       

   
    }
}
