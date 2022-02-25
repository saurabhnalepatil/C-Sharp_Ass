/*
Write a program which accept number from user and return the count of odd 
digits.
Input : 2395 Output : 3
Input : 1018
Output : 2
Input : -1018
Output : 2
Input : 8462
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
			iRet = obj.OddCount(iValue);

			Console.WriteLine("Count Odd digit is : "+iRet);
		}
	}
}

class Lucifer
{
	public int OddCount(int iNo)
	{
		int iDigit = 0,iCnt = 0;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			if(iDigit == 2)
			{
				iCnt++;
			}		
			iNo = iNo / 10;
		}
		return iCnt;
	}
}