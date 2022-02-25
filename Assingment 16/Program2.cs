/*
Accept N numbers from user and display all such elements which are 
divisible by 5.
Input : N : 6
Elements :85 66 3 80 93 88
Output : 85 80
Program Layout :
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter the number of Elements :");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptArr(iLen);
			obj.Accept();
			obj.Display();
			obj.Divisible();
		}
	}
}

class ArrayX
{
	public int[] Arr;

	public void AcceptArr(int iSize)
	{
		Arr = new int[iSize];
	}
	public void Accept()
	{
		Console.WriteLine("Enter Elements : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			Arr[iCnt] = int.Parse(Console.ReadLine());
		}
	}
	public void Display()
	{
		Console.WriteLine("Divisible is 5 : ");
	}
}

class Lucifer : ArrayX
{
	public void Divisible()
	{
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 5) == 0)
			{
				Console.WriteLine(Arr[iCnt]);
			}
		}
	}
}