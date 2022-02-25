/*
Write a program which accept string from user and copy the 
contents of that string into another string. (Implement strcpy() 
function)
Input : “Marvellous Multi OS”
Output : “Marvellous Multi OS”
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Display();
			obj.Copystr();

			//Console.WriteLine("Index of Character : "+iRet);
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
		Console.WriteLine("Copy String is : ");
	}
}

class Lucifer : StringX
{
	public void Copystr()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			Console.Write(ch);
		}
	}
}