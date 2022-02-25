/*
Write a program which accept number from user and print even factors of that 
number. 
Input : 36
Output: 2 6 12 18 
*/

using System;

namespace DisplayEvenFactApp
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.DisplayEFact(iValue);
		}
	}
}

class Lucifer
{
	public void DisplayEFact(int iNo)
	{
		for(int iCnt = 1; iCnt <= iNo / 2; iCnt++)
		{
			if((iCnt % 2) == 0)
			{
				Console.WriteLine(" "+iCnt);
			}
		}
	}
}