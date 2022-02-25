/*
Write java program which accept array from user and reverse each 
number of that array.
Input : 89 687 56 549 87 9
Output : 98 786 65 945 78 9
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
		int iDigit = 0;
		Console.WriteLine("Reverse Element in Array ->");
		for(int i = 0; i < Arr.Length; i++)
		{
			while(Arr[i] != 0)
			{
				iDigit = Arr[i] % 10;
				Console.Write(iDigit);
				Arr[i] = Arr[i] / 10;
			}
			Console.Write(" ");
		}
	}	
}