using System;


namespace FirstApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C формат {0:C}" , 9342);
            Console.WriteLine("D8 формат {0:D8}", 9342);
            Console.WriteLine("E формат {0:E}", 9342);
            Console.WriteLine("F формат {0:F}", 9342);
            Console.WriteLine("N формат {0:N}", 9342);
            Console.WriteLine("X формат {0:X}", 9342);
            Console.WriteLine("P формат {0:P}", 9342);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Подстановка:");
            Console.WriteLine("C = {0:C} D8 = {1:D8}", 922.12,13);
            Console.ReadKey();
        }
    }
}
