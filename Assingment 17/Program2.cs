/*
Accept N numbers from user and return difference between frequency of 
even number and odd numbers.
Input : N : 7
Elements :85 66 3 80 93 88 90
Output : 1 (4 -3)
Program Layout : 
*/
using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of Elements : ");
			int iLen= int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			int iRet = obj.DiffOddEven();

			Console.WriteLine("Diff Between Odd or Even No : "+iRet);
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
	public int DiffOddEven()
	{
		int iCountE = 0, iCountO = 0, iDiff = 0;
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 2) == 0)
			{
				iCountE++;
			}
			else{
				iCountO++;
			}
		}
		iDiff = iCountE - iCountO;
		return iDiff;
	}
}