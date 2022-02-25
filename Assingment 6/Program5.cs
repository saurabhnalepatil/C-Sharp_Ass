/*
Write a program which accept number from user and return difference between 
summation of even digits and summation of odd digits.
Input : 2395 
Output : -15 (2 - 17)
Input : 1018
Output : 6 (8 - 2)
Input : 8440
Output : 16 (16 - 0)
Input : 5733
Output : -18 (0 - 18)
*/

using System;

namespace DigitApp
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			int iValue = 0, iRet = 0;
			
			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.DiffSum(iValue);

			Console.WriteLine("Difference Between Even or Odd Sum : "+iRet);
		}
	}
}

class Lucifer
{
	public int DiffSum(int iNo)
	{
		int iDigit = 0,iSum = 0, jSum = 0,iDiff = 0;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			if((iDigit % 2) == 0)
			{
				iSum = iSum + iDigit;
			}
			else
			{
				jSum = jSum + iDigit;
			}
			iNo = iNo / 10;
		}
		iDiff = iSum - jSum;
		return iDiff;
	}
}