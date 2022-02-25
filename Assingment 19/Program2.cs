/*
Accept N numbers from user and return the smallest number.
Input : N : 6
Elements :85 66 3 66 93 88
Output : 3
Program Layout :
*/

using System;

namespace Apllication
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter numbers of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrMemory(iLen);
			obj.AcceptArr();
			int iRet = obj.MinimumEle();

			Console.WriteLine("Minimum element in array : "+iRet);
		}
	}
}
class ArrayX
{
	public int[] Arr;
	public void ArrMemory(int iSize)
	{
		Arr = new int[iSize];
	}
	public void AcceptArr()
	{
		Console.WriteLine("Enter number " +Arr.Length+" Elements :");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			Arr[iCnt] = int.Parse(Console.ReadLine());
		}
	}
}

class Lucifer : ArrayX
{
	public int MinimumEle()
	{
		int iCnt = 0,iMin = Arr[iCnt];
		for(iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if(Arr[iCnt] < iMin)
			{
				iMin = Arr[iCnt];
			}
		}
		return iMin;
	}
}