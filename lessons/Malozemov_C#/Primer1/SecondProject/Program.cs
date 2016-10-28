using System;


namespace SecondProject
{
    class Program
    {
        static void Main()
        {
            int x,y;
            Console.Write("Введите x =");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y =");
            y = Convert.ToInt32(Console.ReadLine());

            int z = x*y;
            int d,m;
            double v1,v2=0;
          
            d = x/y;
            v1 = x/y;
            m = x%y;
            v2 = (double) x/y;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Произведение = {0} * {1} = {2}", x, y, z);
            Console.WriteLine("Целое деление = {0} / {1} = {2}", x, y, d);
            Console.WriteLine("Деление целых в перменную с плав точк = {0} / {1} = {2}", x, y, v1);
            Console.WriteLine("Остаток от деления = {0} % {1} = {2}", x, y, m);
            Console.WriteLine("Деление с преобразованием = {0} / {1} = {2}", x, y, v2);
            Console.ReadLine();


        }
    }
}
