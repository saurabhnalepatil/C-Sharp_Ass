/*
Accept N numbers from user and display summation of digits of each 
number.
Input : N : 6
Elements :8225 665 3 76 953 858
Output : 17 17 3 13 17 21
Program Layout :
*/

using System;

namespace Apllication
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter numbers of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrMemory(iLen);
			obj.AcceptArr();
			obj.SumArrDig();
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
	public void SumArrDig()
	{
		int iDigit = 0, iSum = 0;
		Console.WriteLine("Display array Elements to Sum of Digit : ");
		for(int i = 0; i < Arr.Length; i++)
		{
			while(Arr[i] != 0){
				iDigit = Arr[i] % 10;
				iSum = iSum + iDigit;
				Arr[i] = Arr[i] / 10;
			}
			Console.Write(iSum+" ");
			iSum = 0;
		}
	}
}