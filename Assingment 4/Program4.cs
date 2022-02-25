/*
Write a program which accept number from user and return summation of all its 
non factors.
Input : 12
Output : 50
Input : 10
Output : 37
*/
using System;

namespace FactNonSumApp
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			int iValue = 0,iRet = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.SumNonFact(iValue);

			Console.WriteLine(iValue+" :-Non Fact Sumation is : "+iRet);

		}
	}
}


class Lucifer
{
	public int SumNonFact(int iNo)
	{
		int iSum = 0;
		for(int iCnt = 1; iCnt <= iNo; iCnt++)
		{
			if((iNo % iCnt) != 0)
			{
				iSum = iSum + iCnt;
			}			
		}
		return iSum;
	}
}

