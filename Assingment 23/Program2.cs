/*
Write a program which accept string from user and convert it into 
upper case.
Input : “Marvellous Multi OS”
Output : MARVELLOUS MULTI OS
*/
using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
			obj.StrUpperX();
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
		Console.WriteLine("String to Upper case Convert : ");
	}
}

class Lucifer : StringX
{
	public void StrUpperX()
	{
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'a') && (ch <= 'z'))
			{
				ch = (char)(ch+'A' - 'a');
				Console.Write(ch);
			}
			else{
				Console.Write(ch);
			}
		}
	}
}