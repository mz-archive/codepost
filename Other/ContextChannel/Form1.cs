using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace ContextChannel
{
    public partial class Form1 : Form
    {

        public int marzha, pribil;
        public double CTR, CV, PPC, invest, ROI, showers, visitors, orders;
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            marzha = Convert.ToInt32(textBox1.Text);
            pribil = Convert.ToInt32(textBox4.Text);
            CTR = Convert.ToDouble(textBox2.Text);
            CV = Convert.ToDouble(textBox3.Text);
            PPC = Convert.ToDouble(textBox7.Text);

            orders = pribil / marzha;
            visitors = orders * 100 / CV;
            showers = visitors * 100 / CTR;
            invest = visitors * PPC;
            ROI = pribil / invest;

            textBox5.Text = invest.ToString();
            textBox6.Text = ROI.ToString();

            GraphPane pane = zedGraphControl1.GraphPane;

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

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            int itemscount = 10;


            Random rnd = new Random();

            // Подписи под столбиками
            string[] names = new string[itemscount];

            double[] YValues1 = new double[itemscount];
            double[] YValues2 = new double[itemscount];
            double[] YValues3 = new double[itemscount];



            double[] XValues1 = new double[itemscount];





            for (int i = 0; i < itemscount; i++)
            {
                XValues1[i] = i + 1;
            }

            YValues1[0] = showers;
            YValues2[0] = visitors;
            YValues3[0] = orders;

            BarItem bar1 = pane.AddBar("Показы", XValues1, YValues1, Color.Blue);
            BarItem bar2 = pane.AddBar("Посетители(кликли)", XValues1, YValues2, Color.Red);

            BarItem bar3 = pane.AddBar("Заказы", XValues1, YValues3, Color.Yellow);



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
            pane.YAxis.Scale.MaxAuto = pane.YAxis.Scale.MinAuto;

            // !!! Установим значение параметра IsBoundedRanges как true.
            // !!! Это означает, что при автоматическом подборе масштаба
            // !!! нужно учитывать только видимый интервал графика
            pane.IsBoundedRanges = true;

            // Изменим тест надписи по оси X
            pane.XAxis.Title.Text = "";

            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "Кол-во";

            // Изменим текст заголовка графика
            pane.Title.Text = "Необходимы следующие показатели";

            // Обновляем график
            zedGraphControl1.Invalidate();

            pane.XAxis.Scale.MajorStep = 100.0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

     
    }
}
