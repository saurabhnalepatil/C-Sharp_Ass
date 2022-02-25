/*
Write C# program which accept number of rows and number of 
columns from user and display below pattern.
Input : iRow = 4 iCol = 3
Output :
1 2 3
1 2 3
1 2 3
1 2 3
Program Layout : 
*/

using System;

namespace Appliction
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

		Console.WriteLine("Pattern is : ");
		for(i = 1; i <= iRow; i++)
		{
			for(j = 1; j <= iCol; j++)
			{
				Console.Write(" "+j);
			}
			Console.WriteLine(" ");
		}
		
	}
}