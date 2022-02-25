/*
Write a program which accept one number from user and count number of 
ON (1) bits in it without using % and / operator.
Input : 11
Output : 3
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
			int iRet = obj.CountBit();

			Console.WriteLine("Total bit On is : "+iRet);
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
	public int CountBit()
	{
		int i = 0, iCnt = 0;
		int iMask = 0x00000001; 
		int iReuslt = 0;

		for(i = 0; i < 32; i++)
		{
			iReuslt = iNo & iMask;
			if(iReuslt == iMask)
			{
				iCnt++;
			}
			iMask = iMask<<1;
		}
		return iCnt;
	}
}