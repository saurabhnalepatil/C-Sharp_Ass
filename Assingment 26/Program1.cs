/*
Write a program which accept string from user and copy that 
characters of that string into another string in reverse order.
Input : “Marvellous Python”
Output : “nohtyP suollevraM”
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
			//obj.Display();
			string sRet = obj.CopystrRev();

			Console.WriteLine("Reverse String is : "+sRet);
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
}

class Lucifer : StringX
{
	public String CopystrRev()
	{
		char Temp;
		int iStart = 0, iEnd = str1.Length -1;
		char[] ch = str1.ToCharArray();

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