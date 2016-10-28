using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLearning
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 5, 23, 123, 421, 124 };
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
