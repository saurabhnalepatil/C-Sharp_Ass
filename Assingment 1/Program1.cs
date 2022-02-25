using System;

namespace DivideAppication
{
	class Program1
	{
		static void Main(string[] arg)
		{
			int iValue1 = 0, iValue2 = 0, iRet = 0;

			Console.WriteLine("Enter First Number : ");
			iValue1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Second Number : ");
			iValue2 = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();

			iRet = obj.Divide(iValue1,iValue2);

			Console.WriteLine("Dividation is : "+iRet);
		}
	}
}

class Lucifer
{
	public int Divide(int iNo1, int iNo2)
	{
		int iResult = 0;

		iResult = iNo1 / iNo2;

		return iResult;
	}
}