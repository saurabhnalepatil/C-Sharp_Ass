/*
Write a program which accept string from user and return 
difference between frequency of small characters and frequency of 
capital characters.
Input : “MarvellouS”
Output : 6 (8-2)
*/
using System;

namespace Application
{
	class Program3
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.Difference();

			Console.WriteLine("Diff Cap & Small later of String : "+iRet);
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
	public int Difference()
	{
		int iCnt = 0,jCnt = 0;
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'a') && (ch <= 'z'))
			{
				iCnt++;
			}
			if((ch >= 'A') && (ch <= 'Z'))
			{
				jCnt++;
			}
		}
		return iCnt - jCnt;
	}
}