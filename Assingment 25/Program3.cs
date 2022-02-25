/*
Write a program which accept string from user and copy capital 
characters of that string into another string.
Input : “Marvellous Multi OS”
Output : “MMOS”
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
			obj.CopystrCap();
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
		Console.WriteLine("Copy Capital Later String is : ");
	}
}

class Lucifer : StringX
{
	public void CopystrCap()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			if((ch >= 'A') && (ch <= 'Z'))
			Console.Write(ch);
		}
	}
}