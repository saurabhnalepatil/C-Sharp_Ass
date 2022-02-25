/*
Write a program which accept string from user and copy that 
characters of that string into another string by converting all small 
characters into capital case.
Input : “Marvellous Python 2”
Output : “MARVELLOUS PYTHON 2”
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
			obj.ConStrCap();
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
		Console.WriteLine("Convert String Capital Later is : ");
	}
}

class Lucifer : StringX
{
	public void ConStrCap()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			if((ch >= 'a') && (ch <= 'z'))
			{
				Console.Write((char)(ch+ 'A' - 'a'));
			}
			else{
				Console.Write(ch);
			}
		}
	}
}