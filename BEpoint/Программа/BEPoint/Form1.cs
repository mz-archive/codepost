using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Finisar.SQLite;
using ZedGraph;
using System.Drawing.Drawing2D;

namespace BEPoint
{
    public partial class Form1 : Form
    {

        public double fixcost, vcost, qsales, part_vcost, vipusk1, qsales_money, sum_cost1, sum_cost2, BreakEvenPoint_money, BreakEvenPoint_count, shag, price;
        public string s_fixcost, s_vcost, s_qsales, s_qsales_money, s_price;
        public int id_now;
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        public Form1()
        {
            InitializeComponent();

            zedGraphControl1.ContextMenuBuilder +=
            new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
            PreDrawGraph();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=dbBEP.db;Version=3;New=True;Compress=True;");


            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "CREATE TABLE data_BEP(" +
                                        "id INT(11) NOT NULL," +
                                         "name CHAR(20) NOT NULL," +
                                         "fixcost FLOAT(7, 3)," +
                                         "vcost FLOAT(7, 3)," +
                                         "qsales FLOAT(7,3)," +
                                          "qsales_money FLOAT(7, 3)," + 
                                            "price FLOAT(1, 2));";


            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(0, 'Анальгин, N10', 12503.667, 42818.559, 129721.396, 47996.916, 0.37);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(1, 'Аспаркам, N10', 30639.643, 85033.507, 534609.848, 117614.166, 0.22);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(2, 'Аспаркам, N50', 8179.855, 19945.036, 22428.154, 31399.416, 1.4);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(3, 'Диклофенак, №30', 6003.643, 6641.818, 8863.75, 23045.75, 2.6);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(4, 'Баралгин, N10', 10690.215, 20010.056, 51294.687, 41035.75, 0.8);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(5, 'Фталазол, N10', 1165.434, 3368.418, 8133.939, 4473.667, 0.55);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO data_BEP(id, name, fixcost, vcost, qsales, qsales_money, price) VALUES(6, 'Цитрамон, №6', 14044.604, 31151.093, 245054.545, 53912, 0.22);";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();



            



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

        public void PreDrawGraph()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;

            // !!!
            // Изменим тест надписи по оси X
            pane.XAxis.Title.Text = "Выпуск";
       

            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "Затраты";

            // Изменим текст заголовка графика
            pane.Title.Text = "Точка безубыточности";


            // Сделаем шрифт не полужирным
            pane.Title.FontSpec.IsBold = true;


            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

          
            
            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            fixcost = Convert.ToDouble(textBox1.Text); //Постоянные затраты,b
            vcost = Convert.ToDouble(textBox2.Text);  // Переменные
            qsales = Convert.ToDouble(textBox3.Text); //Выпуск (Объем реализации) в ед
            qsales_money = Convert.ToDouble(textBox4.Text); // Выпуск в грн
            price = Convert.ToDouble(s_price); //цена в грн за еденицу

            part_vcost = vcost / qsales_money; //Доля переменных затрат в выпуске,a

            vipusk1 = 0;

            sum_cost1 = fixcost + vipusk1;
            sum_cost2 = fixcost + vcost;
            BreakEvenPoint_money = fixcost / (1-part_vcost); //точка безубыточности(грн)
            BreakEvenPoint_count = BreakEvenPoint_money / price; //точка безубыточности(ед)

            //-------------------------------------------------------------------
            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;
            double xmin = 0;
            double xmax = qsales;
            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = xmin;
            pane.XAxis.Scale.Max = xmax + 1000;




            // !!!
            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = xmax + 1000;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear ();

            // Создадим список точек для кривой f1(x)
            PointPairList f1_list = new PointPairList ();

            // Создадим список точек для кривой f2(x)
            PointPairList f2_list = new PointPairList ();

            PointPairList f3_list = new PointPairList();

            PointPairList f4_list = new PointPairList();

            PointPairList f5_bep = new PointPairList();

            PointPairList f6_bep = new PointPairList();


            for (double x = xmin; x <= xmax; x++) 
            {
                f1_list.Add(x, fixcost);
            }

            f2_list.Add(0, 0);
            f2_list.Add(qsales, vcost);

            f3_list.Add(vipusk1, vipusk1);
            f3_list.Add(qsales, qsales_money);
            f3_list.Add(BreakEvenPoint_count, BreakEvenPoint_money);

            f4_list.Add(vipusk1, sum_cost1);
            f4_list.Add(qsales, sum_cost2);

            f5_bep.Add(BreakEvenPoint_count, 0);
            f5_bep.Add(BreakEvenPoint_count, BreakEvenPoint_money);

            f6_bep.Add(BreakEvenPoint_count, BreakEvenPoint_money);
            f6_bep.Add(xmax + 1000, BreakEvenPoint_money);

            

            LineItem f1_curve = pane.AddCurve("Постоянные затраты", f1_list, Color.Magenta, SymbolType.None);
            LineItem f2_curve = pane.AddCurve("Переменные затраты", f2_list, Color.Tomato, SymbolType.None);
            LineItem f3_curve = pane.AddCurve("Объем продаж в грн", f3_list, Color.Blue, SymbolType.None);
            LineItem f4_curve = pane.AddCurve("Суммарные затраты", f4_list, Color.Cyan, SymbolType.None);
            LineItem f5_curve = pane.AddCurve("Точка безубыточности", f5_bep, Color.Black, SymbolType.None);
            LineItem f6_curve = pane.AddCurve("Точка безубыточности", f6_bep, Color.Black, SymbolType.None);

            f5_curve.Line.Style = DashStyle.DashDot;
            f6_curve.Line.Style = DashStyle.DashDot;

            f5_curve.Line.IsSmooth = true;
            f6_curve.Line.IsSmooth = true;

            // Cделаем чуть помальче шрифт, чтобы уместилось побольше меток
            pane.XAxis.Scale.FontSpec.Size = 10;
            pane.YAxis.Scale.FontSpec.Size = 10; 
             
            // !!! Просто уберем отображение степени в подписи оси X
            pane.XAxis.Title.IsOmitMag = true;
            pane.YAxis.Title.IsOmitMag = true;

            // !!! Сами установим коэффициент, на который умножается значение по оси X
            // !!! В данном случае значение будет умножаться на 10^-9
            pane.XAxis.Scale.Mag = 0;

            // Параметры оси Y
            // !!! Установим коэффициент, на который умножается значение по оси Y
            // !!! В данном случае значение будет умножаться на 10^0 = 1, то есть умножения не будет
            pane.YAxis.Scale.Mag = 0;

            // Крупные риски по оси X будут идти с периодом 5
            pane.XAxis.Scale.MajorStep = 2000.0;

            // Мелкие риски будут идти с периодом 1
            // Таким образом, между крупными рисками будет 3 делений или 2 риски
            pane.XAxis.Scale.MinorStep = 1000.0;

            // Крупные риски по оси Y будут идти с периодом 0.1
            pane.YAxis.Scale.MajorStep = 2000.0;

            // А мелкие риски - с периодом 0.05
            // Между крупными рисками по оси Y будет два отсчета или одна риска
            pane.YAxis.Scale.MinorStep = 1000.0;

            /*
            // Включаем отображение сетки напротив крупных рисок по оси X
    pane.XAxis.MajorGrid.IsVisible = true;

    // Задаем вид пунктирной линии для крупных рисок по оси X:
    // Длина штрихов равна 10 пикселям, ...
    pane.XAxis.MajorGrid.DashOn = 10;

    // затем 5 пикселей - пропуск
    pane.XAxis.MajorGrid.DashOff = 5;


    // Включаем отображение сетки напротив крупных рисок по оси Y
    pane.YAxis.MajorGrid.IsVisible = true;

    // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
    pane.YAxis.MajorGrid.DashOn = 10;
    pane.YAxis.MajorGrid.DashOff = 5;


    // Включаем отображение сетки напротив мелких рисок по оси X
    pane.YAxis.MinorGrid.IsVisible = true;

    // Задаем вид пунктирной линии для крупных рисок по оси Y:
    // Длина штрихов равна одному пикселю, ...
    pane.YAxis.MinorGrid.DashOn = 1;

    // затем 2 пикселя - пропуск
    pane.YAxis.MinorGrid.DashOff = 2;

    // Включаем отображение сетки напротив мелких рисок по оси Y
    pane.XAxis.MinorGrid.IsVisible = true;

    // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
    pane.XAxis.MinorGrid.DashOn = 1;
    pane.XAxis.MinorGrid.DashOff = 2;
    */          
             


            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();








            
            

        }

        public double Qsales(double x)
        {
            
            return (part_vcost * x) / 2;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_now = comboBox1.SelectedIndex;
            sqlite_conn = new SQLiteConnection("Data Source=dbBEP.db;Version=3;New=False;Compress=False;");

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            //switch
            switch (id_now)
            {
                case 0:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=0";
                    break;
                case 1:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=1";
                    break;
                case 2:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=2";
                    break;
                case 3:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=3";
                    break;
                case 4:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=4";
                    break;
                case 5:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=5";
                    break;
                case 6:
                    sqlite_cmd.CommandText = "SELECT fixcost, vcost, qsales, qsales_money, price FROM data_BEP WHERE id=6";
                    break;
               
            }


            //switch

            sqlite_datareader = sqlite_cmd.ExecuteReader();


            while (sqlite_datareader.Read())
            {

                s_fixcost = Convert.ToString(sqlite_datareader["fixcost"]);
                s_vcost = Convert.ToString(sqlite_datareader["vcost"]);
                s_qsales = Convert.ToString(sqlite_datareader["qsales"]);
                s_qsales_money = Convert.ToString(sqlite_datareader["qsales_money"]);
                s_price = Convert.ToString(sqlite_datareader["price"]);
            }

            sqlite_conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.AppendText(s_fixcost);
            textBox2.AppendText(s_vcost);
            textBox3.AppendText(s_qsales);
            textBox4.AppendText(s_qsales_money);
            

            


            
        }
    }
}
