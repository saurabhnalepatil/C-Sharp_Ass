/*
Write Java program which accept N numbers from user and display 
all such elements which are multiples of 11.
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
		public static void Main(string[] arg)
		{
			Console.WriteLine("Enter the number of Elements :");
			int iLen = int.Parse(Console.ReadLine());
			
			Lucifer obj = new Lucifer();
			obj.ArrayX(iLen);
			obj.Accept();
			obj.Multiples();
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
	public void Multiples()
	{
		Console.WriteLine("Multiples by 11 Elements in array:-> ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 11) == 0)
			{
				Console.Write(Arr[iCnt]+" ");
			}
		}
	}
}