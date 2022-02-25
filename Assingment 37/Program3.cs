/*
Write Java program which accept number of rows and number of 
columns from user and display below pattern.
Input : iRow = 3 iCol = 5
Output : 
5 4 3 2 1
5 4 3 2 1
5 4 3 2 1
Program Layout :
*/

using System;

namespace Appliction
{
	class Program3
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
		
		Console.WriteLine("Pattern is : ");
		for(i = 1; i <= iRow; i++)
		{
			for(j = iCol ; j >= 1; j--)
			{
				Console.Write(" "+j);
			}
			Console.WriteLine(" ");
		}
		
	}
}