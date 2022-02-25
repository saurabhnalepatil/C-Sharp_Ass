/*
Write a program which 2 strings from user and concat second string 
after first string. (Implement strcat() function).
Input : “Marvellous Infosystems”
“Logic Building”
Output : “Marvellous Infosystems Logic Building”
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
			obj.JoinStr();
		}
	}
}

class StringX 
{
	public String str1,str2;

	public void Accept1()
	{
		Console.WriteLine("Enter First String : ");
		str1 = Console.ReadLine();

		Console.WriteLine("Enter Second String : ");
		str2 = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Join String is : ");
	}
}

class Lucifer : StringX
{
	public void JoinStr()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			Console.Write(ch);
		}
		Console.Write(" ");
		for(int i = 0; i < str2.Length; i++)
		{
			char ch = str2[i];
			Console.Write(ch);
		}
	}
}