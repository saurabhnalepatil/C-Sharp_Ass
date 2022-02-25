// Program to print 5 times “Marvellous” on screen.

using System;

namespace PrintApplication
{
	class Program2
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

		int i = 0;
		for(i = 0; i < 5; i++)
		{
			Console.WriteLine(" Lucifer ");
		}
	}
}