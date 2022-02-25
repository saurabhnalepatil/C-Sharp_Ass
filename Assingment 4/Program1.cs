/*
Write a program which accept number from user and display its multiplication of 
factors.
Input : 12
Output : 144 (1 * 2 * 3 * 4 * 6)
Input : 13
Output : 1 (1)
Input : 10
Output : 10 (1 * 2 * 5)
*/

using System;

namespace MultFactApp
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			int iValue = 0,iRet = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.MultFact(iValue);

			Console.WriteLine(iValue+" Factor Multiplication is : "+iRet);

		}
	}
}

class Lucifer
{
	public int MultFact(int iNo)
	{
		int iMult = 1;
		for(int iCnt = 1; iCnt <= iNo / 2; iCnt++)
		{
			if((iNo  % iCnt) == 0)
			{
				iMult = iMult * iCnt;
			}
		}
		return iMult;
	}
}