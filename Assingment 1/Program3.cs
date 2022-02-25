// Program to print 5 to 1 numbers on screen.

using System;

namespace PrintApp
{
	class Program3
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Display();
		}
	}
} 

class Lucifer
{
	public void Display()
	{
		for(int i = 1; i <= 5; i++)
		{
			Console.WriteLine( i );
		}
	}
}