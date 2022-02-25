/*
Write a recursive program which accept string from user and count number 
of characters.
Input : Hello
Output : 5
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
			obj.CountCharR();
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
	public void CountChar()
	{
		
		for(int i = 0; i < Arr.Length; i++)
		{
			if(Arr[i] !=  Arr.Length){
				iCnt++;
			}
		}
		Console.WriteLine("Total Char in String:-> "+iCnt);
	}
	public void CountCharR()
	{	
		if(i < Arr.Length)
		{
			if(Arr[i] != Arr.Length)
			{
				iCnt++;
				i++;
				CountCharR();
			}
		}
		else{
			Console.WriteLine("Total Char in String:-> "+iCnt);
		}
	}
}
