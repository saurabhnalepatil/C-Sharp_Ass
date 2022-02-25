/*
Accept N numbers from user and display all such numbers which contains 
3 digits in it.
Input : N : 6
Elements :8225 665 3 76 953 858
Output : 665 953 858
Program Layout :
*/

using System;

namespace Apllication
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter numbers of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrMemory(iLen);
			obj.AcceptArr();
			obj.Dis3DigEle();
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
	public void Dis3DigEle()
	{
		int iDigit = 0, iCnt = 0,temp;
		Console.WriteLine("Display Elements to Digit Count is three in array: ");
		for(int i = 0; i < Arr.Length; i++)
		{
			temp = Arr[i];
			while(Arr[i] != 0){
				iDigit = Arr[i] % 10;
				iCnt++;
				Arr[i] = Arr[i] / 10;
			}
			if(iCnt == 3){
				Console.Write(temp+" ");
			}
			iCnt = 0;
		}
	}
}