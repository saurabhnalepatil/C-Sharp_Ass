/*
Write a recursive program which accept number from user and display below 
pattern. 
Input : 5
Output : 5 * 4 * 3 * 2 * 1 *
Prototype : 
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptNum();
			obj.PatternR();
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
	public void Pattern()
	{
		while(value != 0)
		{
			Console.Write(value+" * ");

			value--;
		}
	}
	public void PatternR()
	{	
		if(value != 0)
		{
			Console.Write(value+" * ");
			value--;
			PatternR();
		}
	}
}
