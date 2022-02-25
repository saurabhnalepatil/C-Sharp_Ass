/*
Write a java program which accept string from user and display 
it in reverse order.
Input : “MarvellouS”
Output : “SuollevraM”
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			string sRet = obj.RevStrX();

			Console.WriteLine("Reveres String is : "+sRet);
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
}

class Lucifer : StringX
{
	public String RevStrX()
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