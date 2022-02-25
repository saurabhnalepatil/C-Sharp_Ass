/*
Write a recursive program which accept number from user and return its 
reverse number. 
Input : 523
Output : 325
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
			obj.ReverseR();
		}
	}
}

class Lucifer
{ 
	public static int value;
	public void AcceptNum()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void Reverse()
	{
		while(value != 0)
		{
			int iDigit = 0;
			iDigit = value % 10;
			Console.Write(iDigit);
			value = value / 10;
		}
	}
	public void ReverseR()
	{	
		int iDigit = 0;
		if(value != 0)
		{
			iDigit = value % 10;
			Console.Write(iDigit);
			value = value / 10;
			ReverseR();
		}
	}
}
