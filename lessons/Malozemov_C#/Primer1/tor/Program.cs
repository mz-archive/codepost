using System;

namespace tor
{
    class Tor
    {
        double R;
        double r;

        public Tor()
        {
            Console.Write("Введите R тора =");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите r тора =");
            r = Convert.ToDouble(Console.ReadLine());
        }
        public double Stor()
        {
            double S;
            S = (2*Math.PI*R)*(2*Math.PI*r);
            return S;
        }
        public double Vtor()
        {
            double V;
            V = 2*Math.Pow(Math.PI, 2)*R*Math.Pow(r, 2);
            return V;
        }
        static void Main()
        {
            Tor tor = new Tor();
            double pl = tor.Stor();
            double vtora = tor.Vtor();
            Console.WriteLine("S тора = {0}", pl);
            Console.WriteLine("V тора = {0}", vtora);
            Console.ReadKey();
        }
    }
}
