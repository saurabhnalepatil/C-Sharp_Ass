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
			bRet = obj.OnBit();

			if(bRet == true)
			{
				Console.WriteLine("Bit is On");
			}
			else
			{
				Console.WriteLine("Bit is Off");
			}
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
	public bool OnBit()
	{
		int iMask = 0X00000001; 
		int iReuslt = 0;
		if((iPos < 1) && (iPos > 32))
		{
			Console.WriteLine("Invalid Bit Position");
		}
		iMask = iMask<<(iPos -1);
		iReuslt = iNo & iMask;
		if(iReuslt == iMask)
		{
			return true;
		}
		return false;
	}
}