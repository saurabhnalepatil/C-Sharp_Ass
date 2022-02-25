/*
Write a recursive program which display below pattern. 
Output : a b c d e f
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
			obj.PatternR();
		}
	}
}

class Lucifer
{ 
	public static int value;char i = 'a';
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
