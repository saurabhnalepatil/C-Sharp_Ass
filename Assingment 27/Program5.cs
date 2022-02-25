/*
Write a program which checks whether first and last bit is On or 
OFF. First bit means bit number 1 and last bit means bit number 32.
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			bRet = obj.CheckBit();

			if(bRet == true){
				Console.WriteLine("First Or Last Bit is On");
			}
			else{
				Console.WriteLine("Bit is OFF");
			}
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
	public bool CheckBit()
	{
		bool bAns = false;
		long iMask = 0x80000001; 
		long iReuslt = 0;

		iReuslt = iNo & iMask;
		if(iReuslt == iMask)
		{
			bAns = true;
		}
		return bAns;
	}
}