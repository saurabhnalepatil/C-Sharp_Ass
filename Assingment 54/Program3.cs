/*
Write Java program which accept array of characters from user and 
accept one character. Return occurrence of that character without 
considering case.
Input : b N e B R b A i G i B
b
Output : 4
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
			int iRet = obj.CountEle();

			Console.WriteLine("Total char occurrence in array : "+iRet);		}
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
	public int CountEle()
	{	
		Console.WriteLine("Enter a char find occurrence in array :");
		char ch = char.Parse(Console.ReadLine());
		int iCnt = 0;
		for(int i = 0; i < Arr.Length; i++)
		{

			if((Arr[i] >= 'A')&&(Arr[i] <= 'Z'))
			{
				if(Arr[i] == ch){
					iCnt++;
				}
			}
			else if((Arr[i] >= 'a')&&(Arr[i] <= 'z'))
			{
				if(Arr[i] == ch){
					iCnt++;
				}
			}
		}
		return iCnt;
	}	
}