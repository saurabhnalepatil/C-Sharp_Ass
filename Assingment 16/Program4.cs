/*
Accept N numbers from user and display all such elements which are 
divisible by 3 and 5.
Input : N : 6
Elements :85 66 3 15 93 88
Output : 15
Program Layout :
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			obj.Divisible();
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
	public void Divisible()
	{
		Console.WriteLine("Divisible By 3 And 5 : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if(((Arr[iCnt]%5)==0) && ((Arr[iCnt]%3)==0))
			{
				Console.WriteLine(Arr[iCnt]+" ");
			}
		}
	}
}