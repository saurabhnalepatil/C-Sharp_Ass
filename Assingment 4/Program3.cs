/*
Write a program which accept number from user and display all its non factors.
Input : 12
Output : 5 7 8 9 10 11
Input : 13
Output : 2 3 4 5 6 7 8 9 10 11 12
Input : 10
Output : 3 4 6 7 8 9
*/
using System;

namespace FactorsNonApp
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.FactorsNon(iValue);

			//Console.WriteLine(iValue+" Factor Multiplication is : "+iRet);

		}
	}
}


class Lucifer
{
	public void FactorsNon(int iNo)
	{
		for(int iCnt = 1; iCnt <= iNo; iCnt++)
		{
			if((iNo % iCnt) != 0)
			{
				Console.WriteLine(" "+iCnt);
			}			
		}
	}
}

