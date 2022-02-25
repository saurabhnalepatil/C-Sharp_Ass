/*
Accept N numbers from user and display all such elements Which are multiples of  11.
Input : N : 6
Elements :85 66 3 55 93 88
Output : 66 55 88
Program Layout :
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			obj.Multiples();
		}
	}
}
class ArrayX
{
	public int[] Arr;
	public void MemoryArr(int iSize)
	{
		Arr = new int[iSize];
	}
	public void AcceptArr()
	{
		Console.WriteLine("Enter number : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			Arr[iCnt] = int.Parse(Console.ReadLine());
		}
	}
}

class Lucifer : ArrayX
{
	public void Multiples()
	{
		Console.WriteLine("Multiples By 11 : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 11) == 0)
			{
				Console.WriteLine(Arr[iCnt]+" ");
			}
		}
	}
}