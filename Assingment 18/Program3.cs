/*Accept N numbers from user and accept one another number as NO , 
return index of LAST occurrence of that NO.
Input : N : 6
NO: 66
Elements :85 66 3 66 93 88
Output : 3
Input : N : 6
NO: 12
Elements :85 11 3 15 11 111
Output : -1
Program Layout : 
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			obj.AcceptiNo();
			int iRet = obj.FreqLast();

			Console.WriteLine("Index No Last Occ is : "+iRet);
		}
	}
}

class ArrayX
{
	public int[] Arr;public int iNo;
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
	public void AcceptiNo()
	{
		Console.WriteLine("Enter number check IndeX iValue : ");
		iNo = int.Parse(Console.ReadLine());
	}
}

class Lucifer : ArrayX
{
	public int FreqLast()
	{
		int iFreq = 0,i = 0;
		for(int iCnt = Arr.Length-1; iCnt >= 1; iCnt--)
		{
			if(-1 != Arr[iCnt])
        	{
           		iFreq++;
           		i = Arr.Length - iFreq;
            	if(Arr[iCnt] == iNo)
            	{
                	break;
           		}
       		}
		}
		return i;
	}
}