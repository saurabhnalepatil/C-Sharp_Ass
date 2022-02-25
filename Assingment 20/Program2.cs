/*
Accept Character from user and check whether it is alphabet or not 
(A-Z ).
Input : F
Output : TRUE
Input : d
Output : FALSE
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Char CValue;
			bool bRet = false;

			Console.WriteLine("Enter Character :");
			CValue = char.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.ChkAlpha(CValue);

			if(bRet == true)
			{
				Console.WriteLine("It is Character");
			}
			else
			{
				Console.WriteLine("It Not is Character");
			}
		}
	}
}

class Lucifer
{
	public bool ChkAlpha(char ch)
	{
		bool bAns = false;
		if((ch >= 'A') && (ch <= 'Z'))
		{
			bAns = true;
		}
		/*else if((ch >= 'a') && (ch <= 'z'))
		{
			bAns = true;
		}*/
		return bAns;
	}
}