/*Write a program which accept distance in kilometre and convert it into meter. (1 
kilometre = 1000 Meter)
Input : 5
Output : 5000
Input : 12
Output : 12000
*/

using System;

namespace NumberApp
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			int iValue = 0, iRet = 0;

			Console.WriteLine("Enter number : ");
			iValue = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();

			iRet = obj.KMToMeter(iValue);

			Console.WriteLine(iValue+" :-Kilometer to Meter Convert : "+iRet);
		}
	}
}

class Lucifer
{
	public int KMToMeter(int iNo)
	{
		iNo = iNo * 1000;
		return iNo;
	}
}