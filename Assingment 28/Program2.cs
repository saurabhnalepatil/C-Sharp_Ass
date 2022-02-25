/*
Write a program which accept one number from user and off 7th and 10th 
bit of that number. Return modified number.
Input : 577
Output : 1
*/
using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			int iRet = obj.OFFBit();

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
	public int OFFBit()
	{
		int iMask = 0x00000240; 
		int iReuslt = 0;

		iReuslt = iNo ^ iMask;
		
		return iReuslt;
	}
}