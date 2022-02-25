/*
Write a program which accept string from user and copy the 
contents of that string into another string. (Implement strncpy() 
function)
Input : “Marvellous Multi OS”
10
Output : “Marvellous
Note : If third parameter is greater than the size of source string then 
copy whole string into destination.
*/
using System;

namespace Application
{
	class Program1
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Accept2();
			obj.Display();
			obj.CopyNoStr();
		}
	}
}

class StringX 
{
	public String str1;
	public int iNo;

	public void Accept1()
	{
		Console.WriteLine("Enter String : ");
		str1 = Console.ReadLine();
	}
	public void Accept2()
	{
		Console.WriteLine("Enter number : ");
		iNo = int.Parse(Console.ReadLine());
	}
	public void Display()
	{
		Console.WriteLine("Copy String is : ");
	}
}

class Lucifer : StringX
{
	public void CopyNoStr()
	{
		int iCnt = 0;
		for(int i = 0; i < str1.Length; i++)
		{
			iCnt++;
			char ch = str1[i];
			Console.Write(ch);
			if(iCnt == iNo)
			{
				break;
			}
		}
	}
}