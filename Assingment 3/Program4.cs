/*
Accept one character from user and convert case of that character. 
Input : a Output : A 
Input : D Output : d
*/

using System;

namespace DisplayConApp
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			char chtr;

			Console.WriteLine("Enter character : ");
			chtr = Convert.ToChar(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.DisplayCon(chtr);
		}
	}
}

class Lucifer
{
	public void DisplayCon(char cValue)
	{
		if((cValue >= 'A') && ( cValue <= 'Z'))
		{
			Console.WriteLine(" "+cValue );
		}
		else if((cValue >= 'a') && (cValue <= 'z'))
		{
			Console.WriteLine(" "+cValue);
		}
	}
}