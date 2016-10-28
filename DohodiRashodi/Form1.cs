using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Finisar.SQLite;
using System.Globalization;
using ZedGraph;

namespace UchetDohodov_Rashodov
{
    public partial class Form1 : Form
    {

        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public CultureInfo ci = CultureInfo.InvariantCulture;
        public string[] R = new string[10] { "продукты", "связь", "транспорт", "гигиена", "развлечения", "одежда", "медицина", "образование", "коммунальные платежи", "прочее" };
        public string[] D = new string[3] { "зарплата", "премия", "прочее" };
        public string globalDohod, globalRashod, pred_globalDohod, pred_globalRashod;
        public DateTime dateNow;
        public DateTime dateBack;
        public DateTime dateBack_back;
        //Ужасные названия переменных =)
        public double producti, svyaz, transport, gigiena, razvlechenia, odezhda, medicina, obrazovanie, kom_platezhi, prochee;

        public Form1()
        {
            InitializeComponent();
            // !!! Подпишемся на событие, которое будет возникать перед тем,
            // как будет показано контекстное меню.
            zedGraphControl1.ContextMenuBuilder +=
                new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
        }

        void zedGraph_ContextMenuBuilder(ZedGraphControl sender,
        ContextMenuStrip menuStrip,
        Point mousePt,
        ZedGraphControl.ContextMenuObjectState objState)
        {
            // !!!
            // Переименуем (переведем на русский язык) некоторые пункты контекстного меню
            menuStrip.Items[0].Text = "Копировать";
            menuStrip.Items[1].Text = "Сохранить как картинку…";
            menuStrip.Items[2].Text = "Параметры страницы…";
            menuStrip.Items[3].Text = "Печать…";
            menuStrip.Items[4].Text = "Показывать значения в точках…";
            menuStrip.Items[7].Text = "Установить масштаб по умолчанию…";

            // Некоторые пункты удалим
            menuStrip.Items.RemoveAt(5);
            menuStrip.Items.RemoveAt(5);


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=Dohodi_Rashodi.db;Version=3;New=False;Compress=True;");
            
            dateNow = Convert.ToDateTime(dateTimePicker1.Value);
            //Нужно получить дату за 30 дней до теущей....=(
            dateBack = new DateTime(dateNow.Year, dateNow.Month - 1, dateNow.Day);
            dateBack_back = new DateTime(dateBack.Year, dateBack.Month - 1, dateBack.Day);

            
            
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(dohod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                globalDohod = Convert.ToString(sqlite_datareader["summa"]);
                
            }

            sqlite_conn.Close();

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                globalRashod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();

            //За предпоследние месяцы
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(dohod)) AS summa FROM Uchet WHERE ((date > '" + dateBack_back.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateBack.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                pred_globalDohod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack_back.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateBack.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                pred_globalRashod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();

            
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox3.Text = globalDohod;
            textBox4.Text = globalRashod;
            textBox5.Text = Convert.ToString(Convert.ToDouble(globalDohod) - Convert.ToDouble(pred_globalDohod));
            textBox6.Text = Convert.ToString(Convert.ToDouble(globalRashod) - Convert.ToDouble(pred_globalRashod));

            //Ужасный безысходный копипаст =(
            //1
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'продукты'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                producti = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //2
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'связь'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                svyaz = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //3
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'транспорт'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                transport = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //4
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'гигиена'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                gigiena = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //5
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'развлечения'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                razvlechenia = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //6
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'одежда'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                odezhda = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //7
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'медицина'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                medicina = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //8
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'образование'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                obrazovanie = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //9
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'коммунальные платежи'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                kom_platezhi = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //10
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'прочее'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                prochee = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();

            GraphPane pane = zedGraphControl1.GraphPane;



            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            int itemscount = 10;


            Random rnd = new Random();

            // Подписи под столбиками
            string[] names = new string[itemscount];

            double[] YValues1 = new double[itemscount];
            double[] YValues2 = new double[itemscount];
            double[] YValues3 = new double[itemscount];
            double[] YValues4 = new double[itemscount];
            double[] YValues5 = new double[itemscount];
            double[] YValues6 = new double[itemscount];
            double[] YValues7 = new double[itemscount];
            double[] YValues8 = new double[itemscount];
            double[] YValues9 = new double[itemscount];
            double[] YValues10 = new double[itemscount];



            double[] XValues1 = new double[itemscount];
            double[] XValues2 = new double[itemscount];




            for (int i = 0; i < itemscount; i++)
            {
                XValues1[i] = i + 1;
            }
                
            YValues1[0] = svyaz;
            YValues2[0] = transport;
            YValues3[0] = gigiena;
            YValues4[0] = razvlechenia;
            YValues5[0] = odezhda;
            YValues6[0] = medicina;
            YValues7[0] = obrazovanie;
            YValues8[0] = kom_platezhi;
            YValues9[0] = prochee;
            YValues10[0] = producti;



            




            
            BarItem bar1 = pane.AddBar("Продукты", XValues1, YValues10, Color.Blue);
            BarItem bar2 = pane.AddBar("Связь", XValues1, YValues1, Color.Red);
            
            BarItem bar3 = pane.AddBar("Транспорт", XValues1, YValues2, Color.Yellow);
            BarItem bar4 = pane.AddBar("Гигиена", XValues1, YValues3, Color.Green);
             
            BarItem bar5 = pane.AddBar("Развлечения", XValues1, YValues4, Color.Aqua);
            BarItem bar6 = pane.AddBar("Одежда", XValues1, YValues5, Color.HotPink);
            
            BarItem bar7 = pane.AddBar("Медицина", XValues1, YValues6, Color.Indigo);
            BarItem bar8 = pane.AddBar("Образование", XValues1, YValues7, Color.LightBlue);
            BarItem bar9 = pane.AddBar("Коммунальные платежи", XValues1, YValues8, Color.LightCyan);
            BarItem bar10 = pane.AddBar("Прочее", XValues1, YValues9, Color.Chartreuse);
                        

            pane.BarSettings.MinBarGap = 0;

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет


            // Настроим ось X так, чтобы она отображала текстовые данные
            pane.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane.XAxis.Scale.TextLabels = names;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraphControl1.AxisChange();

            // Установим такой интервал изменения по оси X, чтобы наибольшие значения графика
            // остались за пределами отображаемой области
            pane.XAxis.Scale.Min = 0.4;
            pane.XAxis.Scale.Max = 1.7;

            // По оси Y установим автоматический подбор масштаба
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;

            // !!! Установим значение параметра IsBoundedRanges как true.
            // !!! Это означает, что при автоматическом подборе масштаба
            // !!! нужно учитывать только видимый интервал графика
            pane.IsBoundedRanges = true;

            // Изменим тест надписи по оси X
            pane.XAxis.Title.Text = "";

            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "Проценты";

            // Изменим текст заголовка графика
            pane.Title.Text = "Доли расходов по типам";

            // Обновляем график
            zedGraphControl1.Invalidate();

            pane.XAxis.Scale.MajorStep = 100.0;
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            comboBox1.Text = "";
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            comboBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            DateTime d = Convert.ToDateTime(dateTimePicker1.Value);
            CultureInfo ci = CultureInfo.InvariantCulture;

            textBox2.AppendText(d.ToString("yyyy-MM-dd", ci));
             */

            DateTime date = Convert.ToDateTime(dateTimePicker1.Value);
            CultureInfo ci = CultureInfo.InvariantCulture;
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            if ((comboBox1.Text == "") && (comboBox2.Text != ""))
            {
                sqlite_cmd.CommandText = "INSERT INTO Uchet(date, type_R, rashod) VALUES(" + "'" + date.ToString("yyyy-MM-dd", ci) + "', '" + R[comboBox2.SelectedIndex] + "', " + textBox2.Text + ");";
                sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Данные о расходах за " + date.ToString("dd-MM-yyyy", ci) + " успешно внесены!", "Спасибо!");

            }
            else if ((comboBox1.Text != "") && (comboBox2.Text == ""))
            {
                sqlite_cmd.CommandText = "INSERT INTO Uchet(date, type_D, dohod) VALUES(" + "'" + date.ToString("yyyy-MM-dd", ci) + "', '" + D[comboBox1.SelectedIndex] + "', " + textBox1.Text + ");";
                sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Данные о доходах за " + date.ToString("dd-MM-yyyy", ci) + " успешно внесены!", "Спасибо!");
            }
            else if ((comboBox1.Text == "") && (comboBox2.Text == "")) 
            {
                MessageBox.Show("Вы ничего не выбрали! Выберите тип доходов или расходов!", "Внимание!");
            }
            else
            {
                sqlite_cmd.CommandText = "INSERT INTO Uchet(date, type_R, rashod, type_D, dohod) VALUES(" + "'" + date.ToString("yyyy-MM-dd", ci) + "', '" + R[comboBox2.SelectedIndex] + "', " + textBox2.Text + ", '" + D[comboBox1.SelectedIndex] + "', " + textBox1.Text + ");";
                sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Данные о расходах и доходах за " + date.ToString("dd-MM-yyyy", ci) + " успешно внесены!", "Спасибо!");
            }
   
            sqlite_conn.Close();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(dohod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                globalDohod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                globalRashod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();

            //За предпоследние месяцы
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(dohod)) AS summa FROM Uchet WHERE ((date > '" + dateBack_back.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateBack.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                pred_globalDohod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack_back.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateBack.ToString("yyyy-MM-dd", ci) + "'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                pred_globalRashod = Convert.ToString(sqlite_datareader["summa"]);

            }

            sqlite_conn.Close();


            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox3.Text = globalDohod;
            textBox4.Text = globalRashod;
            textBox5.Text = Convert.ToString(Convert.ToDouble(globalDohod) - Convert.ToDouble(pred_globalDohod));
            textBox6.Text = Convert.ToString(Convert.ToDouble(globalRashod) - Convert.ToDouble(pred_globalRashod));

            //Ужасный безысходный копипаст =(
            //1
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'продукты'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                producti = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //2
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'связь'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                svyaz = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //3
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'транспорт'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                transport = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //4
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'гигиена'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                gigiena = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //5
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'развлечения'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                razvlechenia = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //6
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'одежда'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                odezhda = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //7
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'медицина'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                medicina = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //8
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'образование'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                obrazovanie = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //9
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'коммунальные платежи'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                kom_platezhi = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();
            //10
            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT (sum(rashod)) AS summa FROM Uchet WHERE ((date > '" + dateBack.ToString("yyyy-MM-dd", ci) + "') AND (date < '" + dateNow.ToString("yyyy-MM-dd", ci) + "') AND (type_R = 'прочее'));";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                prochee = Convert.ToDouble(Convert.ToString(sqlite_datareader["summa"])) * 100 / Convert.ToDouble(globalRashod);

            }


            sqlite_conn.Close();

            GraphPane pane = zedGraphControl1.GraphPane;



            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            int itemscount = 10;


            Random rnd = new Random();

            // Подписи под столбиками
            string[] names = new string[itemscount];

            double[] YValues1 = new double[itemscount];
            double[] YValues2 = new double[itemscount];
            double[] YValues3 = new double[itemscount];
            double[] YValues4 = new double[itemscount];
            double[] YValues5 = new double[itemscount];
            double[] YValues6 = new double[itemscount];
            double[] YValues7 = new double[itemscount];
            double[] YValues8 = new double[itemscount];
            double[] YValues9 = new double[itemscount];
            double[] YValues10 = new double[itemscount];



            double[] XValues1 = new double[itemscount];
            double[] XValues2 = new double[itemscount];




            for (int i = 0; i < itemscount; i++)
            {
                XValues1[i] = i + 1;
            }

            YValues1[0] = svyaz;
            YValues2[0] = transport;
            YValues3[0] = gigiena;
            YValues4[0] = razvlechenia;
            YValues5[0] = odezhda;
            YValues6[0] = medicina;
            YValues7[0] = obrazovanie;
            YValues8[0] = kom_platezhi;
            YValues9[0] = prochee;
            YValues10[0] = producti;









            BarItem bar1 = pane.AddBar("Продукты", XValues1, YValues10, Color.Blue);
            BarItem bar2 = pane.AddBar("Связь", XValues1, YValues1, Color.Red);

            BarItem bar3 = pane.AddBar("Транспорт", XValues1, YValues2, Color.Yellow);
            BarItem bar4 = pane.AddBar("Гигиена", XValues1, YValues3, Color.Green);

            BarItem bar5 = pane.AddBar("Развлечения", XValues1, YValues4, Color.Aqua);
            BarItem bar6 = pane.AddBar("Одежда", XValues1, YValues5, Color.HotPink);

            BarItem bar7 = pane.AddBar("Медицина", XValues1, YValues6, Color.Indigo);
            BarItem bar8 = pane.AddBar("Образование", XValues1, YValues7, Color.LightBlue);
            BarItem bar9 = pane.AddBar("Коммунальные платежи", XValues1, YValues8, Color.LightCyan);
            BarItem bar10 = pane.AddBar("Прочее", XValues1, YValues9, Color.Chartreuse);


            pane.BarSettings.MinBarGap = 0;

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет


            // Настроим ось X так, чтобы она отображала текстовые данные
            pane.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane.XAxis.Scale.TextLabels = names;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraphControl1.AxisChange();

            // Установим такой интервал изменения по оси X, чтобы наибольшие значения графика
            // остались за пределами отображаемой области
            pane.XAxis.Scale.Min = 0.4;
            pane.XAxis.Scale.Max = 1.7;

            // По оси Y установим автоматический подбор масштаба
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;

            // !!! Установим значение параметра IsBoundedRanges как true.
            // !!! Это означает, что при автоматическом подборе масштаба
            // !!! нужно учитывать только видимый интервал графика
            pane.IsBoundedRanges = true;

            // Изменим тест надписи по оси X
            pane.XAxis.Title.Text = "";

            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "Проценты";

            // Изменим текст заголовка графика
            pane.Title.Text = "Доли расходов по типам";

            // Обновляем график
            zedGraphControl1.Invalidate();

            pane.XAxis.Scale.MajorStep = 100.0;
        }

              
    }
}
