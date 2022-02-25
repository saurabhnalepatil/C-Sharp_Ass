/*
Write a program which accept one number from user and toggle contents 
of first and last nibble of the number. Return modified number. (Nibble is a group of four bits)
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
			long iRet = obj.ToggleNible();

			Console.WriteLine("Updated Value is : "+iRet);
		}
	}
}

class Number
{
	public long iNo;

	public void Accept()
	{
		Console.WriteLine("Enter Number : ");
		iNo = long.Parse(Console.ReadLine());
	}
}

class Lucifer : Number
{
	public long ToggleNible()
	{
		long iMask = 0xf000000f; 
		long iReuslt = 0;
		
		iReuslt = iNo ^ iMask;
		
		return iReuslt;
	}
}