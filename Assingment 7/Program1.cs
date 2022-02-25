/*
Write a program which accept radius of circle from user and calculate its area. 
Consider value of PI as 3.14. (Area = PI * Radius * Radius)
Input : 5.3 
Output : 88.2026
Input : 10.4 
Output : 339.6224
*/

using System;

namespace NumberApp
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			float fValue = 0;
			double dRet = 0;

			Console.WriteLine("Enter number : ");
			fValue = float.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();

			dRet = obj.CircleArea(fValue);

			Console.WriteLine(" Circle Area : "+dRet);
		}
	}
}

class Lucifer
{
	public double CircleArea(float fRadius)
	{
		double dArea = 0;

		dArea = 3.14 * (fRadius * fRadius);

		return dArea;
	}
}