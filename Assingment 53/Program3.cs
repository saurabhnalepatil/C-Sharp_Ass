/*
Write java program which accept array of characters from user and 
count number of capital characters.
Input : b N j B R b A d G G
Output : 6
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1);
			obj.AccceptArr();
			obj.CountCapital();
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
			Arr[i] = Console.ReadLine()[0];
		}
	}
}

class Lucifer : ArrayX
{
	public void CountCapital()
	{
		int iCnt = 0;
		
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] >= 'A')&&(Arr[i] <= 'Z'))
			{
				iCnt++;
			}
		}
		Console.WriteLine("Count char element in Array ->"+iCnt);
	}	
}