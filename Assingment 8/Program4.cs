/*
Write a program which accept range from user and return addition of all even 
numbers in between that range. (Range should contains positive numbers only)
Input : 23 30 
Output : 108
Input : 10 18
Output : 70
Input : -10 2
Output : Invalid range
Input : 90 18
Output : Invalid range
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0, iValue2 = 0,iRet = 0;
			
			Console.WriteLine("Enter Start of No : ");
			iValue1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter End of No : ");
			iValue2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.EvenSumBet(iValue1,iValue2);

			Console.WriteLine("Even Between no Sum : "+iRet);
		}
	}
}

class Lucifer
{
	public int EvenSumBet(int iStart, int iEnd)
	{
		int iCnt = 0,iSum = 0;
		if(iStart > iEnd)
		{
			Console.WriteLine("Invalid Range");
		}
		for(iCnt = iStart ; iCnt <= iEnd; iCnt++)
		{
			if((iCnt % 2) == 0)
			{
				iSum = iSum + iCnt;
			}			
		}
		return iSum;
	}
}