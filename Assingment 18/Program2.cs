/*Accept N numbers from user and accept one another number as NO , 
return index of first occurrence of that NO.
Input : N : 6
NO: 66
Elements :85 66 3 66 93 88
Output : 1
Input : N : 6
NO: 12
Elements :85 11 3 15 11 111
Output : -1
Program Layout : 
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			Console.WriteLine("Enter number of Elements : ");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.MemoryArr(iLen);
			obj.AcceptArr();
			obj.Acceptvalue();
			int iRet = obj.CheckIndex();

			Console.WriteLine("Index No is : "+iRet);
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
		Console.WriteLine("Enter Check No Present Index : ");
		iValue = int.Parse(Console.ReadLine());
	}
}

class Lucifer : ArrayX
{
	public int CheckIndex()
	{
		int iCnt = 0;
		for(iCnt = 0; iCnt < Arr.Length; iCnt++)
		{
			if(-1 != Arr[iCnt])
        	{
            	if(Arr[iCnt] == iValue)
            	{
                	break;
           		}
       		}
		}
		return iCnt;
	}
}