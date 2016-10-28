using System;

namespace FirstProg
{
    class Prog
	{
		public static int Main()
		{
		   
		   Console.BackgroundColor = ConsoleColor.Gray;
		   Console.ForegroundColor = ConsoleColor.Yellow;
		   Console.Clear();
		   
		   Console.WriteLine("Консольное приложение");
		   DateTime dt1;
		   dt1 = DateTime.Now;
		   Console.WriteLine("Время - {0}", dt1);
		   
		   Console.ReadKey();
		   return 0;    	
			
		}
	}	
	

}