/*
.Write a recursive program which display below pattern. 
Output : 5 4 3 2 1 
Prototype : 
*/

using System;

namespace Application
{
	class Program3
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
	public static int value,i = value;
	public void AcceptNum()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void Pattern()
	{
		while(value != 0)
		{
			Console.Write(value+" ");
			value--;
		}
	}
	public void PatternR()
	{	
		if(value != 0)
		{
			Console.Write(value+" ");
			value--;
			PatternR();
		}
	}
}
