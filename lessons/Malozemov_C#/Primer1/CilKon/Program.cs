using System;

namespace CilKon
{
    class Konus
    {
        double R;
        double H;
        double L;

        public Konus()
        {
            Console.Write("Введите R конуса = ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите H Конуса = ");
            H = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите L Конуса = ");
            L = Convert.ToDouble(Console.ReadLine());
            
        }

        public double Mkonus()
        {
            double M;
            M = Math.PI*R*L;
            return M;
        }
        public double Skonus()
        {
            double S;
            S = Math.PI*R*L + Math.PI*Math.Pow(R, 2);
            return S;
            
        }
        public double Vkonus()
        {
            double V;
            V = Math.PI*Math.Pow(R, 2)*H/3;
            return V;
            
        }

        static void Main()
        {
            Konus konus = new Konus();
            double mkonus = konus.Mkonus();
            double skonus = konus.Skonus();
            double vkonus = konus.Vkonus();
            Console.WriteLine("M конуса = {0}", mkonus);
            Console.WriteLine("s конуса = {0}", skonus);
            Console.WriteLine("V конуса = {0}", vkonus);
            Console.ReadKey();
            Cilindr k = new Cilindr();
            k.Res();
        }
    }

   
    class Cilindr
    {
        double R;
        double H;

        public Cilindr()
        {

            Console.Write("Введите R = ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите H = ");
            H = Convert.ToDouble(Console.ReadLine());
        }
        public double Mcil()
        {
            double M;
            M = Math.PI*R*H;
            return M;
            
        }
        public double Scil()
        {
            double S;
            S = 2*Math.PI*R*H + 2*Math.PI*Math.Pow(R, 2);
            return S;
        }
        public double Vcil()
        {
            double V;
            V = Math.PI*Math.Pow(R, 2)*H;
            return V;
            
        }
        public void Res()
        {
            Console.WriteLine("Расчет для Цилиндра ");
            //Cilindr cilindr = new Cilindr();
            double mcil = Mcil();
            double scil = Scil();
            double vscil = Vcil();
            Console.WriteLine("M цилиндра = {0}", mcil);
            Console.WriteLine("S цилиндра = {0}", scil);
            Console.WriteLine("V цилиндра = {0}", vscil);
            Console.ReadKey();



        }
    }
}
