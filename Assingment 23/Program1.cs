/*
Write a program which accept string from user and convert it into 
lower case.
Input : “Marvellous Multi OS”
Output : marvellous multi os
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
			obj.StrLowerX();
		}
	}
}

class StringX 
{
	public String str;

	public void Accept()
	{
		Console.WriteLine("Enter String : ");
		str = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("String to Lower case Convert : ");
	}
}

class Lucifer : StringX
{
	public void StrLowerX()
	{
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'A') && (ch <= 'Z'))
			{
				ch = (char)(ch+'a' - 'A');
				Console.Write(ch);
			}
			else{
				Console.Write(ch);
			}
		}
	}
}