/*
Write a recursive program which display below pattern. 
Output : 1 2 3 4 5
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
			obj.AcceptNum();
			obj.PatternR();
		}
	}
}

class Lucifer
{ 
	public static int value,i = 1;
	public void AcceptNum()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void Pattern()
	{
		while(value != 0)
		{
			Console.Write(i+" ");
			value--;
			i++;
		}
	}
	public void PatternR()
	{	
		if(value != 0)
		{
			Console.Write(i+" ");
			i++;
			value--;
			PatternR();
		}
	}
}
