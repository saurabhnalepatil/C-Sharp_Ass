/*
Write a program which accept number from user and check whether it contains 0 
in it or not.
Input : 2395 
Output : There is no Zero
Input : 1018
Output : It Contains Zero
Input : 9000
Output : It Contains Zero
Input : 10687
Output : It Contains Zero
*/

using System;

namespace DigitApp
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;
			bool bRet = false;
			
			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.ChechZero(iValue);

			if(bRet == true)
			{
				Console.WriteLine(" It Contain Zero ");
			}	
			else
			{
				Console.WriteLine(" There is No Zero");
			}
		}
	}
}

class Lucifer
{
	public bool ChechZero(int iNo)
	{
		int iDigit = 0;
		bool bAns = false;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			if(iDigit == 0)
			{
				return bAns = true;
			}		
			iNo = iNo / 10;
		}
		return bAns;
	}
}