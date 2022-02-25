/*
Write a program which accept string from user and accept one 
character. Return frequency of that character.
Input : “Marvellous Multi OS”
M
Output : 2
Input : “Marvellous Multi OS”
W
Output : 0
*/
using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Accept2();
			int iRet = obj.CountChar();

			Console.WriteLine("Count of Character : "+iRet);
		}
	}
}

class StringX 
{
	public String str1;
	public char str2;

	public void Accept1()
	{
		Console.WriteLine("Enter String : ");
		str1 = Console.ReadLine();
	}
	public void Accept2()
	{
		Console.WriteLine("Enter Character to Count Freq : ");
		str2 = char.Parse(Console.ReadLine());
	}
}

class Lucifer : StringX
{
	int iCnt = 0;
	public int CountChar()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			if(ch == str2)
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}