/*
Write a program which accept accept range from user and display all numbers in 
between that range in reverse order.
Input : 23 35 
Output : 35 34 33 32 31 30 29 28 27 26 25 24 23
Input : 10 18
Output : 18 17 16 15 14 13 12 11 10
Input : 10 10
Output : 10
Input : -10 2
Output : 2 1 0 -1 -2 -3 -4 -5 -6 -7 -8 -9 -10
Input : 90 18
Output : Invalid range
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0, iValue2 = 0;
			
			Console.WriteLine("Enter Start of No : ");
			iValue1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter End of No : ");
			iValue2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.RevOrd(iValue1,iValue2);

			//Console.WriteLine("Between no Sum : "+iRet);
		}
	}
}

class Lucifer
{
	public void RevOrd(int iStart, int iEnd)
	{
		int iCnt = 0;
		if(iStart > iEnd)
		{
			Console.WriteLine("Invalid Range");
		}
		for(iCnt = iEnd ; iCnt >= iStart; iCnt--)
		{
			Console.WriteLine(" "+iCnt);
		}
	}
}