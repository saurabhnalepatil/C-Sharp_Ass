/*
Accept number from user and display below pattern.
Input : 8
Output : 2 4 6 8 10 12 14 16
Program Layout : 
*/

using System;

namespace Appication
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Pattern(iValue);
		}
	}
}

class Lucifer
{
	public void Pattern(int iNo)
	{
		int iCnt = 0;

		for(iCnt = 1; iCnt <= iNo * 2; iCnt++)
		{
			if((iCnt % 2)==0)
			{
				Console.Write(" "+iCnt);
			}
			
		}
	}
}