/*
Write a program which accept number from user and return difference between 
summation of all its factors and non factors.
Input : 12
Output : -34 (16 - 50)
Input : 10
Output : -29 (8 - 37)
*/

using System;

namespace FactDiffApp
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			int iValue = 0,iRet = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.DiffFact(iValue);

			Console.WriteLine(iValue+" :-Non Fact Sumation is : "+iRet);

		}
	}
}


class Lucifer
{
	public int DiffFact(int iNo)
	{
		int iSum = 0, jSum = 0, iDiff = 0;
		for(int iCnt = 1; iCnt < iNo ; iCnt++)
		{
			if((iNo % iCnt) == 0)
			{
				iSum = iSum + iCnt;
			}
			else
			{
				jSum = jSum + iCnt;
			}			
		}
		iDiff = iSum - jSum;
		return iDiff;
	}
}

