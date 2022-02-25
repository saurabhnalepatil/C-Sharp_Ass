/*
Write a program which accept number from user and print even factors of that 
number. 
Input : 24
Output: 1 2 4 6 8 12
*/

using System;

namespace DisplayFactApp
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.DisplayFact(iValue);
		}
	}
}

class Lucifer
{
	public void DisplayFact(int iNo)
	{
		for(int iCnt = 1; iCnt <= iNo / 2 ; iCnt++)
		{
			if((iCnt % 2) == 0)
			{
				Console.WriteLine(" "+iCnt);
			}
		}
	}
}