using System;

namespace ball
{
    class SandV
    {
        double R;
        public SandV()
        {
            Console.Write("Введите R шара = ");
            R = Convert.ToDouble(Console.ReadLine());
        }

        public double Sball()
        {
            double S;
            S = 4*Math.PI*Math.Pow(R, 2);
            return S;

        }
        public double Vball()
        {
            double V;
            V = 4*Math.PI*Math.Pow(R, 3);
            return V;
        }

        static void Main()
        {
            SandV sandv = new SandV();
            double sball = sandv.Sball();
            double vball = sandv.Vball();
            Console.WriteLine("S поверхности шара = {0}", sball);
            Console.WriteLine("V шара = {0}", vball);
            Console.ReadKey();
        }
    }
}
