/*
Write a program which accept one number from user and off 7th bit of that 
number if it is on. Return modified number.
Input : 79
Output : 15
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
		int iMask = 0x00000040; 
		int iReuslt = 0;

		iReuslt = iNo ^ iMask;
		
		return iReuslt;
	}
}