/*
Write a program which accept one number from user and toggle 7th bit of 
that number. Return modified number.
Input : 137
Output : 201
*/
using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.ToggleBit();

			Console.WriteLine("Updated Value is : "+iRet);
		}
	}
}

class Number
{
	public int iNo;

	public void Accept()
	{
		Console.WriteLine("Enter Number : ");
		iNo = int.Parse(Console.ReadLine());
	}
}

class Lucifer : Number
{
	public int ToggleBit()
	{
		int iMask = 0x00000040; 
		int iReuslt = 0;

		iReuslt = iNo ^ iMask;
		
		return iReuslt;
	}
}