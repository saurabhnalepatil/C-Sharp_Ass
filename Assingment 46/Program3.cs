/*
Write a recursive program which accept string from user and count number 
of small characters.
Input : HElloWOrlD
Output : 5
Prototype :
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(string[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptStr();
			obj.SmallLaterR();
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
	public void SmallLater()
	{
		
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] >= 'a')&&(Arr[i] <= 'z'))
			{
				iCnt++;
			}
		}
		Console.WriteLine("Total small later in String:-> "+iCnt);
	}
	public void SmallLaterR()
	{	
		if(i < Arr.Length)
		{
			if((Arr[i] >= 'a')&&(Arr[i] <= 'z'))
			{
				iCnt++;
			}
			i++;
			SmallLaterR();
		}
		else{
			Console.WriteLine("Total small later in String:-> "+iCnt);
		}
	}
}
