/*
Write a recursive program which accept number from user and return 
largest digit
Input : 87983
Output : 9
Prototype :
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(string[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptStr();
			obj.MaxDigitR();
		}
	}
}

class Lucifer
{
	public static int value = 0,iMax = 0;
	public void AcceptStr()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void MaxDigit()
	{
		int iDigit = 0, iMax = 0;
		iDigit = iMax;
		while(value != 0)
		{
			iDigit = value % 10;
			if(iMax < iDigit){
				iMax = iDigit;
			}
			value = value / 10;
		}
		Console.WriteLine("Largest Digit is :-> "+iMax);
	}
	public void MaxDigitR()
	{	
		int iDigit = 0;
		iDigit = iMax;
		if(value != 0)
		{
			iDigit = value % 10;
			if(iMax < iDigit){
				iMax = iDigit;
			}
			value = value / 10;
			MaxDigitR();
		}
		else{
			Console.WriteLine("Largest Digit is :-> "+iMax);

		}
	}
}
