/*
Accept division of student from user and depends on the division 
display exam timing. There are 4 divisions in school as A,B,C,D. Exam 
of division A at 7 AM, B at 8.30 AM, C at 9.20 AM and D at 10.30 AM. 
(Application should be case insensitive)
Input : C
Output : Your exam at 9.20 AM
Input : d
Output : Your exam at 10.30 AM
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			Char CValue;
			bool bRet = false;

			Console.WriteLine("Enter Character :");
			CValue = char.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.ChkAlpha(CValue);

			if(bRet == ch)
			{
				Console.WriteLine("Your exam at 9.30 AM");
			}
			if else
			{
				Console.WriteLine("Your exam at 10.30 AM");
			}

		}
	}
}

class Lucifer
{
	public bool ChkAlpha(char ch)
	{
		bool bAns = false;
		if((ch == A)||(ch == B)||(ch == C)||(ch == D)) 
		{
			
		}
		return bAns;
	}
}