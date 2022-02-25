/*
Write java program which accept array from user and replace each 
member with summation of its digit.
Input : 89 687 56 549 87 9
Output : 17 21 11 18 15 9
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1);
			obj.AccceptArr();
			obj.SumEleDig();
		}
	}
}

class ArrayX
{
	public int[] Arr;
	public void AcceptLen(int size1)
	{
		Arr = new int[size1];
	}
	public void AccceptArr()
	{
		Console.WriteLine("Enter "+Arr.Length+" Element of Array :");
		for(int i = 0; i < Arr.Length; i++)
		{
			Arr[i] = int.Parse(Console.ReadLine());
		}
	}
}

class Lucifer : ArrayX
{
	public void SumEleDig()
	{
		int iDigit = 0, iSum = 0;
		Console.WriteLine("Sum of Digit Element in Array ->");
		for(int i = 0; i < Arr.Length; i++)
		{
			while(Arr[i] != 0)
			{
				iDigit = Arr[i] % 10;
				iSum = iSum + iDigit;
				Arr[i] = Arr[i] / 10;
			}
			Console.Write(iSum+" ");
		}
	}	
}