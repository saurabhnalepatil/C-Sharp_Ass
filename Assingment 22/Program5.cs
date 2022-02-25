/*
Write a program which accept string from user and display it inn 
reverse order.
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
			string sRet = obj.RevString();

			Console.WriteLine("Reverse String is : "+sRet);
		}
	}
}

class StringX
{
	public string str;

	public void Accept()
	{
		Console.WriteLine("Enter the String : ");
		str = Console.ReadLine();
	}
}

class Lucifer : StringX 
{
	public string RevString()
	{
		int iStart = 0,iEnd = str.Length -1;
		char Temp;
		char[] ch = str.ToCharArray();
		while(iStart < iEnd)
		{
			Temp = ch[iStart];
			ch[iStart] = ch[iEnd];
			ch[iEnd] = Temp;
			iStart++;
			iEnd--;
		}
		return new string(ch);
	}
}