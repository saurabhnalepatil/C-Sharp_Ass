/*
Write a java program which accept string from user and return 
difference between frequency of small characters and frequency 
of capital characters. 
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

			Console.WriteLine("Total Diff is : "+iRet);
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
	public int Difference()
	{
		int iCnt = 0, jCnt = 0;
		//char[] Arr =str.ToCharArray();
		//foreach(char ch in Arr)
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'A') && (ch <= 'Z'))
			{
				iCnt++;
			}
			if((ch >= 'a') && (ch <= 'z'))
			{
				jCnt++;
			}
		}
		return jCnt - iCnt;
	}
}