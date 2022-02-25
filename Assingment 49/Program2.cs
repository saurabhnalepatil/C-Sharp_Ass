
/*
 Write a recursive program which accept number from user and return 
summation of its digits.
Input : 879
Output : 24
Prototype :
*/
using System;

namespace Application
{
	class Program5
	{
		public static void Main(string[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptNum();
			obj.SumofDigitR();
		}
	}
}

class Lucifer
{ 
	public static int value,iSum = 0;
	public void AcceptNum()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void SumofDigit()
	{
		while(value != 0)
		{
			int iDigit = 0;
			iDigit = value % 10;
			iSum = iSum + iDigit;
			value = value / 10;
		}
				Console.WriteLine("Number of Digit Sum is ->"+iSum);

	}
	public void SumofDigitR()
	{	
		int iDigit = 0;
		if(value != 0)
		{
			iDigit = value % 10;
			iSum = iSum + iDigit;
			value = value / 10;
			SumofDigitR();
		}
		else{
			Console.WriteLine("Number of Digit Sum is ->"+iSum);
		}
	}
}
