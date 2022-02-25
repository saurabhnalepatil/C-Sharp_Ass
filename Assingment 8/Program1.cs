/*
Write a program which accept range from user and display all numbers in between 
that range.
Input : 23 35 
Output : 23 24 25 26 27 28 29 30 31 32 33 34 35
Input : 10 18
Output : 10 11 12 13 14 15 16 17 18
Input : 10 10
Output : 10
Input : -10 2
Output : -10 -9 -8 -7 -6 -5 -4 -3 -2 -1 0 1 2
Input : 90 18
Output : Invalid range
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0, iValue2 = 0;
			
			Console.WriteLine("Enter Start of No : ");
			iValue1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter End of No : ");
			iValue2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Between(iValue1,iValue2);

			//Console.WriteLine("Between no in 2 Integer : "+iRet);
		}
	}
}

class Lucifer
{
	public void Between(int iStart, int iEnd)
	{
		if(iStart > iEnd)
		{
			Console.WriteLine("Invalied Range");
		}
		for(int i = iStart+1; i < iEnd; i++)
		{
			Console.WriteLine(" "+i);
		}	
	}
}