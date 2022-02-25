/*
Accept N numbers from user and return the largest number.
Input : N : 6
Elements :85 66 3 66 93 88
Output : 93
Program Layout :
*/

using System;

namespace Apllication
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter numbers of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrMemory(iLen);
			obj.AcceptArr();
			int iRet = obj.Maxmium();

			Console.WriteLine("Largest element in array : "+iRet);
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
	public int Maxmium()
	{
		int iCnt = 0,iMax = 0;
		for(iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if(Arr[iCnt] > iMax)
			{
				iMax = Arr[iCnt];
			}
		}
		return iMax;
	}
}