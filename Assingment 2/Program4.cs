/*
Accept two numbers from user and display first number in second 
number of times. 
Input : 12 5 
Output : 12 12 12 12 12
Input : -2 3 
Output : -2 -2 -2 
Input : 21 -3 
Output : 21 21 21 
Input : -2 0 
Output : 
*/

using System;

namespace DisplayApp
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0, iValue2 = 0;

			Console.WriteLine("Enter number : ");
			iValue1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Frequency : ");
			iValue2 = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Display(iValue1,iValue2);
		}
	}
}


class Lucifer
{
	public void Display(int iNo, int iFreq)
	{
		int iCnt = 0, i = 0;

		for(iCnt = 1 , i = iNo; iCnt <= iFreq; iCnt++)
		{
			Console.WriteLine(" "+iNo);
		}
	}
}