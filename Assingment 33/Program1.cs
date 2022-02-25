/*
Write a program which accept number from user and return the count of even 
digits.
Input : 2395 
Output : 1
Input : 1018
Output : 2
Input : -1018
Output : 2
Input : 8462
Output : 4
*/

using System;

namespace DigitApp
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			int iValue = 0, iRet = 0;
			
			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			iRet = obj.EvenCount(iValue);

			Console.WriteLine("Count Even Digit is : "+iRet);
		}
	}
}

class Lucifer
{
	public int EvenCount(int iNo)
	{
		int iDigit = 0,iCnt = 0;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			if((iDigit % 2) == 0)
			{
				iCnt++;
			}		
			iNo = iNo / 10;
		}
		return iCnt;
	}
}