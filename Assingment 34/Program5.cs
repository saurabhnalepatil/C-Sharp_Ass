/*
Write java program which accept N numbers from user and return 
product of all odd elements.
Input : N : 6
Elements :15 66 3 70 10 88
Output : 45
Input : N : 6
Elements :44 66 72 70 10 88
Output : 0
Program Layout : 
*/

using System;

namespace Appliction
{
	class Program5
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter length of Array");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrayX(iLen);
			obj.AcceptArr();
			int iret = obj.OddMult();
			Console.WriteLine("Odd number of element in product-> "+iret);
		}
	}
}

class Lucifer
{
	public int[] Arr;
	public void ArrayX(int size)
	{
		Arr = new int [size];
	}
	public void AcceptArr()
	{
		Console.WriteLine("Enter the element of Array");
		for(int i = 0; i < Arr.Length; i++)
		{
			Arr[i] = int.Parse(Console.ReadLine());
		}
	}
	public int OddMult()
	{
		int iMult = 1;
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] % 2)!=0)
			{
				iMult = iMult * Arr[i];
			}
		}
		return iMult;
	}
}