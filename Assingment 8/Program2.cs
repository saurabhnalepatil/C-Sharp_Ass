/*
Write a program which accept range from user and display all even numbers in between that range.
Input : 23 35 
Output : 24 26 28 30 32 34
Input : 10 18
Output : 10 12 14 16 18
Input : 10 10
Output : 10
Input : -10 2
Output : -10 -8 -6 -4 -2 0 2
Input : 90 18
Output : Invalid range
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0, iValue2 = 0;
			
			Console.WriteLine("Enter Start of No : ");
			iValue1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter End of No : ");
			iValue2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.BetweenEven(iValue1,iValue2);

			//Console.WriteLine("Between no in 2 Integer : "+iRet);
		}
	}
}

class Lucifer
{
	public void BetweenEven(int iStart, int iEnd)
	{
		if(iStart > iEnd)
		{
			Console.WriteLine("Invalied Range");
		}

		for(int i = iStart+1; i < iEnd; i++)
		{
			if((i % 2) == 0)
			{
				Console.WriteLine(" "+i);		
			}
		}	
	}
}