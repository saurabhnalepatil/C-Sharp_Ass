/*
Write a program which accept string from user and toggle the case.
Input : “Marvellous Multi OS”
Output : mARVELLOUS mULTI os
*/
using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
			obj.StrToggleX();
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
		Console.WriteLine("String to Toggle character Convert : ");
	}
}

class Lucifer : StringX
{
	public void StrToggleX()
	{
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'A') && (ch <= 'Z'))
			{
				ch = (char)(ch+'a' - 'A');
				Console.Write(ch);
			}
			else if((ch >= 'a') && (ch <= 'z'))
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