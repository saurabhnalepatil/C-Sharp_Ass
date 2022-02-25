/*
Write a program which accept string from user and count number of 
small characters.
Input : “Marvellous”
Output : 9
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.CountSmall();

			Console.WriteLine("Total count of String : "+iRet);
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
	public int CountSmall()
	{
		int iCnt = 0;
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'a') && (ch <= 'z'))
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}