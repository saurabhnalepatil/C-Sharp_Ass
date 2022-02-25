/*
Write a program which accept temperature in Fahrenheit and convert it into 
celsius. (1 celsius = (Fahrenheit -32) * (5/9))
Input : 10
Output : -12.2222 (10 - 32) * (5/9)
Input : 34
Output : 1.11111 (34 - 32) * (5/9)
*/

using System;

namespace NumberApp
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			float fValue = 0.0f;
			double dRet = 0.0d;

			Console.WriteLine("Enter Tempreture in Fahrenhiet : ");
			fValue = float.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();

			dRet = obj.ConCelsius(fValue);

			Console.WriteLine("Tempreture Con "+fValue+" Fahrenhiet to  Celsius : "+dRet);
		}
	}
}

class Lucifer
{
	public double ConCelsius(float fTemp)
	{
		double dCel = 0.0;

		dCel = (fTemp - 32) * (0.555556);

		return dCel;
	}
}