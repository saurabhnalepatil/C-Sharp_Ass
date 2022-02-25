/*
Write a program which accept one number from user and print that number of 
even numbers on screen. 
Input : 7 
Output: 2 4 6 8 10 12 14
*/

using System;

namespace PrintEvenApp
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.PrintEven(iValue);
		}
	}
}

class Lucifer
{
	public void PrintEven(int iNo)
	{
		int iCnt = 0;
		for(iCnt = 1; iCnt <= iNo * 2; iCnt++)
		{
			if((iCnt % 2) == 0)
			{
				Console.WriteLine(" "+iCnt);
			}
		}
	}
}