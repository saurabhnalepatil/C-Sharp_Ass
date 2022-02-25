/*
Accept number of rows and number of columns from user and display 
below pattern.
Input : iRow = 3 iCol = 4
Output :
 1 1 1 1
2 2 2 2
3 3 3 3
4 4 4 4
Program Layout : 
*/

using System;

namespace Appication
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			int iValue1 = 0,iValue2 = 0;

			Console.WriteLine("Enter number Rows : ");
			iValue1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter number Columns : ");
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

		for(int i = 1; i <= iRow; i++)
		{
			for(int j = 1; j <= iCol; j++)
			{
				Console.Write(" "+i);
			}
			Console.WriteLine("");
		}

	}
}