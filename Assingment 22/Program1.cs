/*
Write a program which accept string from user and count number of 
capital characters.
Input : “Marvellous Multi OS”
Output : 4
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.CountCapital();

			Console.WriteLine("Total Capital Later is : "+iRet);
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
	public int CountCapital()
	{
		int iCnt = 0;
		//char[] Arr =str.ToCharArray();
		//foreach(char ch in Arr)
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch >= 'A') && (ch <= 'Z'))
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}