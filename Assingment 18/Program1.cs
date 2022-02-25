/*
Accept N numbers from user check whether that numbers contains 11 in 
it or not.
Input : N : 6
Elements :85 66 11 80 93 88
Output : 11 is present
Input : N : 6
Elements :85 66 3 80 93 88
Output : 11 is absent
Program Layout :
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			bool bRet = false;
			Console.WriteLine("Enter number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			obj.Acceptvalue();
			bRet = obj.FreqEven();

			if(bRet == true){
				Console.WriteLine("is Present ");
			}
			else{
				Console.WriteLine("is Not Present ");
			}
		}
	}
}

class ArrayX
{
	public int[] Arr;public int iValue;
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
	public void Acceptvalue()
	{
		Console.WriteLine("Enter Check No Present : ");
		iValue = int.Parse(Console.ReadLine());
	}
}
class Lucifer : ArrayX
{
	public bool FreqEven()
	{
		bool bAns = false;
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if(Arr[iCnt] == iValue)
			{
				bAns = true;
			}
		}
		return bAns;
	}
}