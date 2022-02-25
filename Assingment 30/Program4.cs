/*
Write a program which accept one number , two positions from user and 
check whether bit at first or bit at second position is ON or OFF.
Input : 10 3 7
Output : TRUE
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			bRet = obj.CheckBit();

			if(bRet == true)
			{
				Console.WriteLine("Bit is ON");
			}
			else{
				Console.WriteLine("Bit is OFF");
			}
		}
	}
}

class Number
{
	public int iNo,iPos1,iPos2;

	public void Accept()
	{
		Console.WriteLine("Enter Number : ");
		iNo = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter first porsition Number : ");
		iPos1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter second position Number : ");
		iPos2 = int.Parse(Console.ReadLine());
	}
}

class Lucifer : Number
{
	public bool CheckBit()
	{
		bool bAns = false;
		int iMask1 = 0x00000001;
		int iMask2 = 0x00000001; 
		int iReuslt = 0;
		int iMask = 0;

		iMask1 = iMask1<<(iPos1 -1);
		iMask2 = iMask2<<(iPos2 -1);
		iMask = iMask1 | iMask2;
		iReuslt = iNo & iMask;
		if(iReuslt == iMask)
		{
			bAns = true;
		}
		return bAns;
	}
}