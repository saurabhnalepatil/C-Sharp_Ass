/*
Write a program which accept string from user and accept one 
character. Return index of first occurrence of that character.
Input : “Marvellous Multi OS”
M
Output : 0
Input : “Marvellous Multi OS”
W
Output : -1
Input : “Marvellous Multi OS”
e
Output : 4
*/
using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Accept2();
			int iRet = obj.IndexFirst();

			Console.WriteLine("Index of Character : "+iRet);
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
		Console.WriteLine("Enter Character to check Index no. : ");
		str2 = char.Parse(Console.ReadLine());
	}
}

class Lucifer : StringX
{
	int iCnt = 0;
	public int IndexFirst()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			iCnt++;
			if(ch == str2)
			{
				break;
			}
		}
		return iCnt;
	}
}