/*
Write java program which accept N numbers from user and accept 
Range, Display all elements from that range
Input : N : 6
Start: 60
End : 90
Elements :85 66 3 76 93 88
Output : 66 76 88
Input : N : 6
Start: 30
End : 50
Elements :85 66 3 76 93 88
Output :
Program Layout : 
*/
using System;

namespace Appliction
{
	class Program4
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter length of Array");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrayX(iLen);
			obj.AcceptArr();
			obj.AcceptiNo();
			obj.BetweenNum();
		}
	}
}

class Lucifer
{
	public int[] Arr;int iStart, iEnd;
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
	public void AcceptiNo()
	{
		Console.WriteLine("Enter the Start point & End Point Number :");
		iStart = int.Parse(Console.ReadLine());
		iEnd = int.Parse(Console.ReadLine());
	}
	public void BetweenNum()
	{
		Console.WriteLine("Between Number is ->");
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] >= iStart)&&(Arr[i] <= iEnd))
			{
				Console.WriteLine(Arr[i]+" ");
			}
		}
	}
}