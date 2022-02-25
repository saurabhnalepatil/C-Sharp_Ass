/*
Write a program which accept number from user and return the count of digits in 
between 3 and 7.
Input : 2395 
Output : 1
Input : 1018
Output : 0
Input : 4521
Output : 2
Input : 9922
Output : 0
*/

using System;

namespace DigitApp
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			int iValue = 0, iRet = 0;
			
			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.FreqCount(iValue);

			Console.WriteLine("Count Digit between in 3 to 7 : "+iRet);
		}
	}
}

class Lucifer
{
	public int FreqCount(int iNo)
	{
		int iDigit = 0,iCnt = 0;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			if((iDigit > 3) && (iDigit < 7))
			{
				iCnt++;
			}		
			iNo = iNo / 10;
		}
		return iCnt;
	}
}