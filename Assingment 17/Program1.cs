/*
Accept N numbers from user and return frequency of even numbers.
Input : N : 6
Elements :85 66 3 80 93 88
Output : 3
Program Layout : 
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			int iRet = obj.FreqEven();

			Console.WriteLine("Frequency of Even No : "+iRet);
		}
	}
}

class ArrayX
{
	public int[] Arr;
	public void MemoryArr(int size)
	{
		Arr = new int[size];
	}
	public void AcceptArr()
	{
		Console.WriteLine("Enter number "+ Arr.Length + " Elements : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			Arr[iCnt] = int.Parse(Console.ReadLine());
		}

	}
}

class Lucifer : ArrayX
{
	public int FreqEven()
	{
		int iCount = 0;
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 2) == 0)
			{
				iCount++;
			}
		}
		return iCount;
	}
}