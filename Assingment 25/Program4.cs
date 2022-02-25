/*
Write a program which accept string from user and copy small 
characters of that string into another string.
Input : “Marvellous multi OS”
Output : “arvellous multi
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Display();
			obj.CopyStrSmall();
		}
	}
}

class StringX 
{
	public String str1;

	public void Accept1()
	{
		Console.WriteLine("Enter String : ");
		str1 = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Copy Small Later String is : ");
	}
}

class Lucifer : StringX
{
	public void CopyStrSmall()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			if((ch >= 'a') && (ch <= 'z'))
			Console.Write(ch);
		}
	}
}