/*
Accept number of rows and number of columns from user and display below 
pattern.
Input : iRow = 4 iCol = 4
Output :
 A B C D
a b c d
A B C D
a b c d
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
		char ch,Ch;int j;
		for(int i = 1; i <= iRow; i++)
		{
			for(j = 1,ch = 'a',Ch = 'A'; j <= iCol;Ch++,ch++, j++)
			{
				if((i % 2)==0)
				{
					Console.Write(" "+ch);
				}
				else
				{
					Console.Write(" "+Ch);
				}	
			}
			Console.WriteLine("");
		}
	}
}