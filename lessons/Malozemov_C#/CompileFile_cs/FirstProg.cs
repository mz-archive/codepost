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
		   
		   Console.WriteLine("���������� ����������");
		   DateTime dt1;
		   dt1 = DateTime.Now;
		   Console.WriteLine("����� - {0}", dt1);
		   
		   Console.ReadKey();
		   return 0;    	
			
		}
	}	
	

}