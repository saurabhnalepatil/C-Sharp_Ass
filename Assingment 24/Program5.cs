/*
Write a program which accept string from user reverse that string 
in place.
Input : “abcd”
Output : “dcba”
Input : “abba”
Output : “abba”
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			//obj.Accept2();
			string sRet = obj.RevStrX();

			Console.WriteLine("Revrese String is : "+sRet);
		}
	}
}

class StringX 
{
	public String str;
	public char str2;

	public void Accept1()
	{
		Console.WriteLine("Enter String : ");
		str = Console.ReadLine();
	}
	public void Accept2()
	{
		Console.WriteLine("Enter Character to check Index no. : ");
		str2 = char.Parse(Console.ReadLine());
	}
}

class Lucifer : StringX
{
	public string RevStrX()
	{
		int iStart = 0, iEnd = str.Length -1;
		char Temp;
		char[] str1 = str.ToCharArray();
		while(iStart < iEnd)
		{
			Temp = str1[iStart];
			str1[iStart] = str1[iEnd];
			str1[iEnd] = Temp;
			iStart++;
			iEnd--;
		}
		return new string(str1);
	}
}