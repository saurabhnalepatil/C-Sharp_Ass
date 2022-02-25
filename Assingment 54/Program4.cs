/*
Write Java program which accept array of characters from user and 
return difference between frequency of capital and frequency of small 
characters.
Input : b N e B R b A I O G i
Output : 3 (7 - 4)
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1);
			obj.AccceptArr();
			int iRet = obj.DiffSmallCap();

			Console.WriteLine("Diff between Small later & Capital later in array : "+iRet);		}
	}
}

class ArrayX
{
	public char[] Arr;
	public void AcceptLen(int size1)
	{
		Arr = new char[size1];
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
	public int DiffSmallCap()
	{	
		int iCnt1 = 0,iCnt2 = 0;
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] >= 'A')&&(Arr[i] <= 'Z'))
			{
				iCnt1++;		
			}
			else if((Arr[i] >= 'a')&&(Arr[i] <= 'z'))
			{
				iCnt2++;
			}
		}
		return iCnt1-iCnt2;
	}	
}