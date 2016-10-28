using System;
using System.Windows.Forms; ///

namespace Primer1
{
    class Test
    {
        public void Message()
        {
            DateTime t;
            t = DateTime.Now;
            MessageBox.Show("Привет\n" + t.ToString("Дата:dd.MM.yyyy dddd\n") +
            t.ToString("Дата:MM.mm\n"), "Окошко");
        }
    }
    class Program
    {
        static void Main()
        {
            string name = "Александр";
            int height = 83;
            int weight = 82;
            Console.WriteLine("Должно получиться так:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Имя: " + name + "\nВес: " + weight + "\nРост: " + height);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите рост: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес: ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Имя: {0}\nРост: {1} кг\nВес: {2} см", name, height, weight);
            Console.ReadKey();
            Test test = new Test(); ////
            test.Message(); ////


        }
    
    }
}

