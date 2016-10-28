using System;

namespace SinT_CosT
{
    class Teilor
    {
        readonly double _x;
        public Teilor()
        {
            Console.Write("x = ");
            _x = Convert.ToDouble(Console.ReadLine());
        }
        public double SinTe()
        {
            double sumSint = 0;
            for (int i = 0; i < 5; i++)
            {
                sumSint = sumSint + ((Math.Pow(-1, i) / (Fact_SinTe(2 * i + 1))) * Math.Pow(_x, 2 * i + 1));
                
            }
            return sumSint;
        }
        public double Fact_SinTe(int vr)
        {
            int sumFsin = 1;
            for (int i = 1; i < vr; i++) 
            {
                sumFsin = sumFsin * (i+1);
            }
            return sumFsin;
        }
        static void Main()
        {
           
            var vTeilor = new Teilor();
            double sint = vTeilor.SinTe();
            Console.WriteLine("Синус Тейлора = {0}", sint);
            Console.ReadKey();
        }
    }
}
