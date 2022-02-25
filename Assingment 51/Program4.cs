/*
Write Java program which accept two arrays from user and form 
new array which is combination of contents of first and second array.
Input : 12 57 28 3
99 23 54 58 6 67
Output : 12 57 28 3 99 23 54 58 6 67
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter second array length :");
			int iLen2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1,iLen2);
			obj.AccceptArr();
			obj.Combination();
		}
	}
}

class ArrayX
{
	public int[] Arr1;public int[] Arr2;public int[] Arr3;
	public void AcceptLen(int size1,int size2)
	{
		int size3 = 0;
		Arr1 = new int[size1];
		Arr2 = new int[size2];
		size3 = size1 + size2;
		Arr3 = new int[size3];
	}
	public void AccceptArr()
	{
		Console.WriteLine("Enter "+Arr1.Length+" Element of Array :");
		for(int i = 0; i < Arr1.Length; i++)
		{
			Arr1[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter "+Arr2.Length+" Element of Array :");
		for(int i = 0; i < Arr2.Length; i++)
		{
			Arr2[i] = int.Parse(Console.ReadLine());
		}
	}
}

class Lucifer : ArrayX
{
	public void Combination()
	{
		int iCnt1 = 0, iCnt2 = 0;
		iCnt1 = Arr1.Length + Arr2.Length;
		iCnt2 = Arr2.Length;

		Console.WriteLine("\nElement in first & second array :");
		for(int i = 0; i < Arr1.Length; i++)
		{
			Console.Write(Arr1[i]+" ");
			Arr1[i]=Arr3[i] = int.Parse(Console.ReadLine());
		}
		for(int i = 0; i < Arr2.Length; i++)
		{
			Console.Write(Arr2[i]+" ");
		}
	}
}
	