/*Write a recursive program which display below pattern. 
Output : * * * * *
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
			Console.Write(" *");
			value--;
		}
	}
	public void PatternR()
	{	
		if(value != 0)
		{
			Console.Write(" *");
			value--;
			PatternR();
		}
	}
}
