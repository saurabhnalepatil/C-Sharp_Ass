/*
Write a program which accept string from user and count number of 
white spaces
Input : “MarvellouS”
Output : 0
Input : “MarvellouS Infosystems”
Output : 1
Input : “MarvellouS Infosystems by Piyush Manohar Khairnnar”
Output : 5
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.CountSpace();

			Console.WriteLine("Total Space in String Line : "+iRet);
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
	public int CountSpace()
	{
		int iCnt = 0;
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if(ch == ' ')
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}