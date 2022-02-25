/*
Write a recursive program which accept string from user and count white 
spaces.
Input : HE llo WOr lD
Output : 3
Prototype : 
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptStr();
			obj.WhiteSpaceR();
		}
	}
}

class Lucifer
{
	public static string str;int iCnt, i;char[] Arr;
	public void AcceptStr()
	{
		Console.WriteLine("Enter the String :");
		str = Console.ReadLine();
	
		Arr = str.ToCharArray();
	}
	public void WhiteSpace()
	{
		
		for(int i = 0; i < Arr.Length; i++)
		{
			if(Arr[i] == ' '){
				iCnt++;
			}
		}
		Console.WriteLine("Total White Space in String:-> "+iCnt);
	}
	public void WhiteSpaceR()
	{	
		if(i < Arr.Length)
		{
			if(Arr[i] == ' '){
				iCnt++;
			}
			i++;
			WhiteSpaceR();
		}
		else{
			Console.WriteLine("Total White Space in String:-> "+iCnt);
		}
	}
}
