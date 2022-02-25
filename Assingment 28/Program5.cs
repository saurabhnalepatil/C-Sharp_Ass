/*
Write a program which accept one number from user and on its first 4 
bits. Return modified number.
Input : 73
Output : 79
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.OnBit();

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
	public int OnBit()
	{
		int iMask = 0x0000000f; 
		int iReuslt = 0;

		iReuslt = iNo | iMask;
		
		return iReuslt;
	}
}