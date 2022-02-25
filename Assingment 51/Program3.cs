/*
Write Java program which accept two arrays from user and display 
odd contents of each array.
Input : 2 9 6 5 2 3
45 6 12 18 23 4
Output : 9 5 3
45 23
*/

using System;

namespace Application
{
	class Program3
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
			obj.OddDisArr();
		}
	}
}

class ArrayX
{
	public int[] Arr1;public int[] Arr2;
	public void AcceptLen(int size1,int size2)
	{
		Arr1 = new int[size1];
		Arr2 = new int[size2];
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
	public void OddDisArr()
	{
		Console.WriteLine("Odd element in first array :");
		for(int i = 0; i < Arr1.Length; i++)
		{
			if((Arr1[i] % 2) != 0){
				Console.Write(Arr1[i]+" ");
			}
		}
		Console.WriteLine("\nOdd element in second array :");
		for(int i = 0; i < Arr2.Length; i++)
		{
			if((Arr2[i] % 2) != 0){
				Console.Write(Arr2[i]+" ");
			}
		}
	}
	
}