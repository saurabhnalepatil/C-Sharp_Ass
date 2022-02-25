/*
Write Java program which accept array from user and display below 
pattern.
Input : 8 9 7 6 4 2 4
Output :
* * * * * * * *
* * * * * *
* * * *
* *
* * * *
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1);
			obj.AccceptArr();
			obj.ReverseDigit();
		}
	}
}

class ArrayX
{
	public int[] Arr;
	public void AcceptLen(int size1)
	{
		Arr = new int[size1];
	}
	public void AccceptArr()
	{
		Console.WriteLine("Enter "+Arr.Length+" Element of Array :");
		for(int i = 0; i < Arr.Length; i++)
		{
			Arr[i] = int.Parse(Console.ReadLine());
		}
	}
}

class Lucifer : ArrayX
{
	public void ReverseDigit()
	{
		Console.WriteLine("Pattern Display in Element of Array ->");
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] % 2) == 0)
			{
				while(Arr[i] != 0)
				{
					Console.Write(" *");
					Arr[i]--;
				}
				Console.WriteLine("");
			}
		}
	}	
}