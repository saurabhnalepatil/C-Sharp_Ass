/*
Accept N numbers from user and accept Range, Display all elements from 
that range
Input : N : 6
Start: 60
End : 90
Elements :85 66 3 76 93 88
Output : 66 76 88
Input : N : 6
Start: 30
End : 50
Elements :85 66 3 76 93 88
Output :
Program Layout :
*/
using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			obj.AcceptValue();
			obj.Between();
		}
	}
}

class ArrayX
{
	public int[] Arr;public int iStart, iEnd;
	public void MemoryArr(int iSize)
	{
		Arr = new int[iSize];
	}
	public void AcceptArr()
	{
		Console.WriteLine("Enter number "+ Arr.Length + " Elements : ");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			Arr[iCnt] = int.Parse(Console.ReadLine());
		}
	}
	public void AcceptValue()
	{
		Console.WriteLine("Enter Start Point Display array Elements : ");
		iStart = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter End Point Display array Elements : ");
		iEnd = int.Parse(Console.ReadLine());
	}
}
class Lucifer : ArrayX
{
	public void Between()
	{
		Console.WriteLine("Between No is "+iStart+" to "+iEnd+" :");
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] >= iStart) && (Arr[iCnt] <= iEnd))
			{
				Console.WriteLine(Arr[iCnt]+" ");
			}
		}
	}
}