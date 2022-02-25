/*
Write a program which accept one number and position from user and 
toggle that bit. Return modified number.
Input : 10 3
Output : 14
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
			int iRet = obj.ToggleBit();

			Console.WriteLine("Updated Value is : "+iRet);
		}
	}
}

class Number
{
	public int iNo,iPos;

	public void Accept()
	{
		Console.WriteLine("Enter Number : ");
		iNo = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter Position : ");
		iPos = int.Parse(Console.ReadLine());
	}
}

class Lucifer : Number
{
	public int ToggleBit()
	{
		int iMask = 0x00000001; 
		int iReuslt = 0;
		if((iPos < 1) && (32 < iPos))
		{
			Console.WriteLine("Invalid Bit Position");
			return 0;
		}
		iMask = iMask<<(iPos -1);
		iReuslt = iNo ^ iMask;
		
		return iReuslt;
	}
}