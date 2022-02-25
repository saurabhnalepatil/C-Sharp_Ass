//Accept one number from user and print that number of * on screen. 

using System;

namespace DisplayApp
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter Number : ");
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
		int iCnt = 0;

		for(iCnt = 1; iCnt <= iNo; iCnt++)
		{
			Console.WriteLine(" * ");
		}
	}
}