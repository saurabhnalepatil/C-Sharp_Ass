//Accept one number from user and print that number of * on screen.

using System;

namespace DisplayApp
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Display(iValue);
		}
	}
}

class Lucifer
{
	public void Display(int iNo)
	{
		while( iNo > 0 )
		{
			Console.WriteLine(" * ");
			iNo--;
		}
	}
}