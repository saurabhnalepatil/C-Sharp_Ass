/*
Write a java program which accept two two arrays from user and 
display minimum element of each array.
Input : 2 9 7 5 2 3
9 3 5 5
Output : 2 3
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

			Console.WriteLine("Enter second array length :");
			int iLen2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1,iLen2);
			obj.AccceptArr();
			obj.MinNumArr();
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
	public void MinNumArr()
	{
		int iMin1 = 0, iMin2 = 0;
		for(int i = 0; i < Arr1.Length; i++)
		{
			if(i == 0){
				iMin1 = Arr1[i];
			}
			if(Arr1[i] < iMin1){
				iMin1 = Arr1[i];
			}
		}
		Console.WriteLine("Smallest element in first array:-> "+iMin1);
		for(int i = 0; i < Arr2.Length; i++)
		{
			if(i == 0){
				iMin2 = Arr2[i];
			}
			if(Arr2[i] < iMin2){
				iMin2 = Arr2[i];
			}
		}
		Console.WriteLine("Smallest element in second array:-> "+iMin2);
	}	
}