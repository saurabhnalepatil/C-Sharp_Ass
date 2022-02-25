/*
Write a program which accept number from user and count frequency of such a digits which are less than 6.
Input : 2395 
Output : 3
Input : 1018
Output : 3
Input : 9440
Output : 3
Input : 96672
Output : 1
*/

using System;

namespace DigitApp
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			int iValue = 0, iRet = 0;
			
			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.FreqCount(iValue);

			Console.WriteLine("Frequency of less 6 is : "+iRet);
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
			if(iDigit < 6)
			{
				iCnt++;
			}		
			iNo = iNo / 10;
		}
		return iCnt;
	}
}