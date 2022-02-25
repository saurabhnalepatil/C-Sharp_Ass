/*
Write a program which accept width & height of rectangle from user and calculate 
its area. (Area = Width * Height)
Input : 5.3 9.78
Output : 51.834
*/

using System;

namespace NumberApp
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			float fValue1 = 0, fValue2 = 0;
			double dRet = 0;

			Console.WriteLine("Enter number Width: ");
			fValue1 = float.Parse(Console.ReadLine());

			Console.WriteLine("Enter number Height: ");
			fValue2 = float.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();

			dRet = obj.CalArea(fValue1,fValue2);

			Console.WriteLine(" Area : "+dRet);
		}
	}
}

class Lucifer
{
	public double CalArea(float fWidth, float fHeight)
	{
		double dArea = 0;

		dArea = (fWidth * fHeight);

		return dArea;
	}
}