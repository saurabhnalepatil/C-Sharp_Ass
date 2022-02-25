/*
Write a program which accept string from user and copy that 
characters of that string into another string by converting all capital 
characters into small case.
Input : “Marvellous Python 2”
Output : “marvellous python 2”
*/
using System;

namespace Application
{
	class Program4
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Display();
			obj.ConStrSmall();
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
		Console.WriteLine("Convert String Small Later is : ");
	}
}

class Lucifer : StringX
{
	public void ConStrSmall()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			if((ch >= 'A') && (ch <= 'Z')){
				Console.Write((char)(ch+ 'a' - 'A'));
			}
			else{
				Console.Write(ch);
			}
		}
	}
}