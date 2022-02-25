/*
Write a program which accept number from user and display its digits in reverse 
order.
Input : 2395 
Output : 
5
9
3
2
Input : 1018
Output : 
8
1
0
1
Input : -1018
Output :
 8
1
0
1
Input : 9000
Output : 
0
0
0
9
*/

using System;

namespace DigitApp
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;
			
			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.DisplayDigit(iValue);	
		}
	}
}

class Lucifer
{
	public void DisplayDigit(int iNo)
	{
		int iDigit = 0;

		while(iNo != 0)
		{
			iDigit = iNo % 10;
			Console.WriteLine(" "+iDigit);
			iNo = iNo / 10;
		}
	}
}