/*
Accept Character from user and check whether it is Digit or not 
(0-9).
Input : 7
Output : TRUE
Input : &
Output : FALSE
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			Char CValue;
			bool bRet = false;

			Console.WriteLine("Enter Value :");
			CValue = char.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.ChkAlpha(CValue);

			if(bRet == true)
			{
				Console.WriteLine("It is Digit");
			}
			else
			{
				Console.WriteLine("It Not is Digit");
			}
		}
	}
}

class Lucifer
{
	public bool ChkAlpha(char ch)
	{
		bool bAns = false;
		if((ch >= '0') && (ch <= '9'))
		{
			bAns = true;
		}
		return bAns;
	}
}