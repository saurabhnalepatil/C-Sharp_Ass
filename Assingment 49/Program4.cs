/*
Write a recursive program which accept number from user and return its 
factorial. 
Input : 5
Output : 120
Prototype : 
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptNum();
			obj.FactorialR();
		}
	}
}

class Lucifer
{ 
	public static int value,iFact = 1,i =1;
	public void AcceptNum()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void Factorial()
	{
		while(value != 0)
		{
			iFact = iFact * i;
			i++;
			value--;

		}
		Console.WriteLine("Number of Digit Factorial is ->"+iFact);
	}
	public void FactorialR()
	{	
		if(value != 0)
		{
			iFact = iFact * i;
			i++;
			value--;
			FactorialR();
		}
		else{
			Console.WriteLine("Number of Digit Factorial is ->"+iFact);
		}
	}
}
