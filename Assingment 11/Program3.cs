/*
Accept number of rows and number of columns from user and display below 
pattern.
Input : iRow = 3 iCol = 5
Output : A A A A A
B B B B B
C C C C C
Program Layout :
*/

using System;

namespace Appication
{
	class Program1
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
		char ch;int i;
		for( i = 1,ch = 'A'; i <= iRow;ch++, i++)
		{
			for(int j = 1; j <= iCol; j++)
			{
				Console.Write(" "+ch);
			}
			Console.WriteLine("");
		}
	}
}