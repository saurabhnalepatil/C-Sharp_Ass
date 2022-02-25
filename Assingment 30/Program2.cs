/*
Write a program which accept two numbers from user and display position 
of common ON bits from that two numbers.
Input : 10 15 (1010 1111)
Output : 2 4
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
			obj.Display();
			obj.DisComBit();

			//Console.WriteLine("Total bit On is : "+iRet);
		}
	}
}

class Number
{
	public int iNo1,iNo2;

	public void Accept()
	{
		Console.WriteLine("Enter First Number : ");
		iNo1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter Second Number : ");
		iNo2 = int.Parse(Console.ReadLine());
	}
	public void Display()
	{
		Console.WriteLine("Common Bit Index No : ");
	}
}

class Lucifer : Number
{
	public void DisComBit()
	{
		int iMask1 = 0x00000001,iMask2 = 0X00000001; 
		int iRet1 = 0, iRet2 = 0;

		for(int i = 1; i < 32; i++)
		{
			iRet1 = iNo1 & iMask1;
			
			for(int j = 1; j < 32; j++)
			{
				iRet2 = iNo2 & iMask2;
				if((iRet1 == iMask1)==(iRet2 == iMask2))
				{
					if(i == j)
					{
						Console.WriteLine(i);
					}
				}
				iMask2 = iMask2<<1;
			}
			iMask1 = iMask1<<1;
		}
	}
}