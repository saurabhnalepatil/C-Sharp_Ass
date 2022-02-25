/*
Write a recursive program which accept number from user and return 
smallest digit
Input : 87983
Output : 3
Prototype :
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(string[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptStr();
			obj.MinDigit();
		}
	}
}

class Lucifer
{
	public static int value = 0,iMin = 9;
	public void AcceptStr()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void MinDigit()
	{
		int iDigit = 0;
		
		while(value != 0)
		{
			iDigit = value % 10;
			if(iMin > iDigit){
				iMin = iDigit;
			}
			value = value / 10;
		}
		Console.WriteLine("Smallest Digit is :-> "+iMin);
	}
	public void MinDigitR()
	{	
		int iDigit = 0;
		if(value != 0)
		{
			iDigit = value % 10;
			if(iMin > iDigit){
				iMin = iDigit;
			}
			value = value / 10;
			MinDigitR();
		}
		else{
			Console.WriteLine("Smallest Digit is :-> "+iMin);

		}
	}
}
