/*
Write a program which checks whether 7th & 15th & 21st , 28th bit 
is On or OFF.
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			bRet = obj.CheckBit();

			if(bRet == true){
				Console.WriteLine("7th,15th,21st & 28th Bit is On");
			}
			else{
				Console.WriteLine("15th Bit is OFF");
			}
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
	public bool CheckBit()
	{
		bool bAns = false;
		int iMask = 0X08104040; 
		int iReuslt = 0;

		iReuslt = iNo & iMask;
		if(iReuslt == iMask)
		{
			bAns = true;
		}
		return bAns;
	}
}