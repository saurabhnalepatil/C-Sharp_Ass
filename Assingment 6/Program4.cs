/*
Write a program which accept number from user and return multiplication of all 
digits.
Input : 2395 
Output : 270
Input : 1018
Output : 8
Input : 9440
Output : 144
Input : 922432
Output : 864
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
			iRet = obj.MultCount(iValue);

			Console.WriteLine("Multi all Digit : "+iRet);
		}
	}
}

class Lucifer
{
	public int MultCount(int iNo)
	{
		int iDigit = 0,iMult = 1;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			iMult = iMult * iDigit;	
			iNo = iNo / 10;
		}
		return iMult;
	}
}