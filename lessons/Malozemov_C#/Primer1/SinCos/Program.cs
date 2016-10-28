using System;


namespace SinCos
{    
    class Trig
    {
        double x;
        

        public Trig()
        {
            
            try
            {
                Console.Write("Введите число = ");
                x = Convert.ToDouble(Console.ReadLine());

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                Environment.Exit(-1);
            }
        
        
        }
        public double Cos()
        {
            return Math.Cos(x);

        }

        public double Sin()
        {
            return Math.Sin(x);
        }
        public double CosT()
        {
            double sum = 0;
            for(int i = 0; i < 5; i++)
            {

                sum = sum + (Math.Pow(-1, i)/(FactCos(2*i)))*Math.Pow(x, 2*i);

               
            }
            return sum;
        }
        
        public double FactCos (int go)
        {
            int sum = 1;
            for (int i = 1; i < go; i++)
            {
                sum = (i+1)*sum;
            }
            return sum;

        }
        public double SinT() 
        {
            double sum = 0;
            for (int i = 0; i < 5; i++) 
            {
                sum = sum + (Math.Pow(-1, i) / (FactSin(2 * i + 1))) * Math.Pow(x, 2 * i + 1);
            }

                return sum;
        }
        public double FactSin(int v) 
        {
            int sum = 1;
            for (int i = 1; i < v; i++)
            {
                sum = (i+1) * sum;
            }
            return sum;
        }


    }
    
   
    
    
    class Program
    {
        static void Main()
        {
            Trig Trig = new Trig();
            double co   =  Trig.Cos();
            double si   =  Trig.Sin();
            double cot  =  Trig.CosT();
            double sint =  Trig.SinT();

            Console.WriteLine("Косинус = {0}", co);
            Console.WriteLine("Косинус тейлора = {0}", cot);
            Console.WriteLine("Синус = {0}", si);
            Console.WriteLine("Синус Тейлора = {0}", sint);
            Console.ReadKey();

            
        }
    }




}
