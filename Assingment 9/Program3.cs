/*
Accept number from user and display below pattern.
Input : 5
Output : 1 * 2 * 3 * 4 * 5 *
Program Layout :
*/

using System;

namespace Appication
{
	class Program2
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
		
		for(iCnt = 1; iCnt <= iNo; iCnt++)
		{
			Console.Write(iCnt+" * ");
		}
	}
}