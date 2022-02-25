/*
Write Java program which accept N numbers from user and return 
difference between summation of even elements and summation of 
odd elements.
Input : N : 6
Elements :85 66 3 80 93 88
Output : 53 (234 - 181)
Program Layout : 
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] arg)
		{
			Console.WriteLine("Enter the number of Elements :");
			int iLen = int.Parse(Console.ReadLine());
			Lucifer obj = new Lucifer();
			obj.ArrayX(iLen);
			obj.Accept();
			int iRet = obj.DigitSum();

			Console.WriteLine("Difference in Odd or Even Ele Sum : "+iRet);
		}
	}
}

class Lucifer  
{
	public int[] Arr;
	public void ArrayX(int iSize)
	{
		Arr = new int[iSize];
	}
	public void Accept()
	{
		Console.WriteLine("Enter "+Arr.Length+" Elements : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			Arr[iCnt] = int.Parse(Console.ReadLine());
		}
	}
	public int DigitSum()
	{
		int ESum = 0, OSum = 0;
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 2) == 0)
			{
				ESum = ESum + Arr[iCnt];
			}
			else{
				OSum = OSum + Arr[iCnt];
			}
		}
		return ESum - OSum;
	}
}