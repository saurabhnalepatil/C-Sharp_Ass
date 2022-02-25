/*
Write a program which accept number from user and count frequency of 4 in it.
Input : 2395 
Output : 0
Input : 1018
Output : 0
Input : 9440
Output : 2
Input : 922432
Output : 1
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
			iRet = obj.FreqCount(iValue);

			Console.WriteLine("Frequency of 4pro is : "+iRet);
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
			if(iDigit == 4)
			{
				iCnt++;
			}		
			iNo = iNo / 10;
		}
		return iCnt;
	}
}