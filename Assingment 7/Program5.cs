/*
Write a program which accept area in square feet and convert it into square 
meter. (1 square feet = 0.0929 Square meter)
Input : 5
Output : 0.464515
Input : 7
Output : 0.650321
*/

using System;

namespace NumberApp
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			float fValue = 0;
			double dRet = 0;

			Console.WriteLine("Enter number : ");
			fValue = float.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();

			dRet = obj.SqaureMeter(fValue);

			Console.WriteLine("Sqaure feet to Sqaure Meter : "+dRet);
		}
	}
}

class Lucifer
{
	public double SqaureMeter(float fSfeet)
	{
		double dMeter = 0.0;

		dMeter =  fSfeet * 0.0929;

		return dMeter;
	}
}