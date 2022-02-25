/*
Write a program which accept number from user and display its factors in 
decreasing order.
Input : 12
Output : 6 4 3 2 1
Input : 13
Output : 1
Input : 10
Output : 5 2 1
*/


using System;

namespace FactorsApp
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Factors(iValue);

			//Console.WriteLine(iValue+" Factor Multiplication is : "+iRet);

		}
	}
}


class Lucifer
{
	public void Factors(int iNo)
	{
		for(int iCnt = iNo / 2; iCnt >= 1; iCnt--)
		{
			if((iNo % iCnt) == 0)
			{
				Console.WriteLine(" "+iCnt);
			}			
		}
	}
}

