/*
Accept N numbers from user and return difference between summation 
of even elements and summation of odd elements.
Input : N : 6
Elements :85 66 3 80 93 88
Output : 53 (234 - 181)
Program Layout : 
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter the number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());
			
			Lucifer obj = new Lucifer();
			obj.AcceptArr(iLen);
			obj.Accept();
			int iRet = obj.Differnce();
			
			Console.WriteLine("Differnce is : "+iRet);
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
}

class Lucifer : ArrayX
{
	public int Differnce()
	{
		int iSum = 0, jSum = 0, iDiff = 0;
		for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if((iCnt % 2) == 0)
			{
				iSum = iSum + Arr[iCnt];
			}
			else{
				jSum = jSum + Arr[iCnt];
			}
		}
		iDiff = iSum - jSum;
		return iDiff;
	}
}
