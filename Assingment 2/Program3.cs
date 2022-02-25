/*
Accept on number from user if number is less than 10 then print 
“Hello” otherwise print “Demo”. 
*/

using System;

namespace DisplayApp
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Display(iValue);
		}
	}
}

class Lucifer
{
	public void Display(int iNo)
	{
		if(iNo < 10)
		{
			Console.WriteLine(" HELLO ");
		}
		else
		{
			Console.WriteLine(" DEMO ");
		}
	}
}