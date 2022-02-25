/*Accept N numbers from user and return product of all odd elements.
Input : N : 6
Elements :15 66 3 70 10 88
Output : 45
Input : N : 6
Elements :44 66 72 70 10 88
Output : 0
Program Layout :
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			int iRet = obj.OddProduct();

			Console.WriteLine("Odd No Product is : "+iRet);
		}
	}
}

class ArrayX
{
	public int[] Arr;
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
}
class Lucifer : ArrayX
{
	public int OddProduct()
	{
		int iPower = 1;
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((Arr[iCnt] % 2) != 0)
			{
				iPower = iPower * Arr[iCnt];
			}
		}
		return iPower;
	}
}