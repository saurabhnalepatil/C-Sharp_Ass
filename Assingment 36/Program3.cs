/*
Write Java program which accept number of rows and number of columns 
from user and display below pattern.
Input : iRow = 2 iCol = 5
Output :
 A A A A A
B B B B B
*/
using System;

namespace Applictionp
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0, iValue2 = 0;

			Console.WriteLine("Enter number of Rows : ");
			iValue1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter number of Columns : ");
			iValue2 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Pattern(iValue1,iValue2);
		}
	}
}

class Lucifer
{
	public void Pattern(int iRow, int iCol)
	{
		int i , j ;
		char  ch;
		Console.WriteLine("Pattern is : ");
		for(i = 0, ch = 'A'; i < iRow;ch++,i++)
		{
			for(j = 0; j < iCol; j++)
			{
				Console.Write(" "+ch);
			}
			Console.WriteLine(" ");
		}
		
	}
}