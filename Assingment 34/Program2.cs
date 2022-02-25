/*Write java program which accept N numbers from user and accept 
one another number as NO , return index of first occurrence of that 
NO.
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

namespace Appliction
{
	class Program2
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter length of Array");
			int iLen = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.ArrayX(iLen);
			obj.AcceptArr();
			obj.AcceptiNo();
			int iret = obj.CheckNum();
			Console.WriteLine("Number in Present in index no-> "+iret);
		}
	}
}

class Lucifer
{
	public int[] Arr;int iNo;
	public void ArrayX(int size)
	{
		Arr = new int [size];
	}
	public void AcceptArr()
	{
		Console.WriteLine("Enter the element of Array");
		for(int i = 0; i < Arr.Length; i++)
		{
			Arr[i] = int.Parse(Console.ReadLine());
		}
	}
	public void AcceptiNo()
	{
		Console.WriteLine("Enter the Check No Present or Not");
		iNo = int.Parse(Console.ReadLine());
	}
	public int CheckNum()
	{
		Console.WriteLine("Check Wheather Number Present or not in array");
		for(int i = 0; i < Arr.Length; i++)
		{
			if(Arr[i] == iNo){
				return i;
			}
		}
		return -1;
	}
}