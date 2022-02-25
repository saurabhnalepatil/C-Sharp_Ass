/*
Write a java program which accepts 2 strings from user and 
concat N characters of second string after first string.Value of N 
should be accepted from user.
Note : If third parameter is greater than the size of second string 
then concat whole string after first string.
Input : “Marvellous Infosystems”
“Logic Building”
5
Output : “Marvellous Infosystems Logic”
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.StringDemo();
		}
	}
}

class StringX
{
	public String str1,str2;

	public void Accept()
	{
		Console.WriteLine("Enter First String : ");
		str1 = Console.ReadLine();

		Console.WriteLine("Enter Second String : ");
		str2 = Console.ReadLine();
	}
}

class Lucifer : StringX
{
	public void StringDemo()
	{
		Console.WriteLine("Output is ->");
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			Console.Write(ch);
		}
		Console.Write(" ");
		for(int j = 0; j < str2.Length; j++)
		{
			char ch = str2[j];
			Console.Write(ch);
		}
	}
}