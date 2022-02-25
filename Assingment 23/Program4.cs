/*
Write a program which accept string from user and display only 
digits from that string.
Input : “marve89llous121”
Output : 89121
Input : “Demo”
Output :
*/
using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
			obj.DisplayDigit();
		}
	}
}

class StringX 
{
	public String str;

	public void Display()
	{
		Console.WriteLine("Under String Display Digit : ");
	}
	public void Accept()
	{
		Console.WriteLine("Enter String : ");
		str = Console.ReadLine();
	}

}

class Lucifer : StringX
{
	public void DisplayDigit()
	{
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= '0') && (ch <= '9'))
			{
				Console.Write(ch);
			}
		}
	}
}