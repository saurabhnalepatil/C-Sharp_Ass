/*
Write Java program which accept N numbers from user and display 
all such elements which are even and divisible by 5.
Input : N : 6
Elements :85 66 3 80 93 88
Output : 80
Program Layout :
*/
using System;

namespace Application
{
	class Program3
	{
		public static void Main(string[] arg)
		{
			Console.WriteLine("Enter the number of Elements :");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrayX(iLen);
			obj.Accept();
			obj.EvenDiv5();
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
	public void EvenDiv5()
	{
		Console.WriteLine("Divisible by 5 even Elements in array:-> ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 2) == 0)
			{
				if((Arr[iCnt] % 5) == 0)
				{
					Console.Write(Arr[iCnt]+" ");
				}
			}
		}
	}
}