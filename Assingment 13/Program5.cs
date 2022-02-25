/*
Accept number of rows and number of columns from user and display below 
pattern.
Input : iRow = 4 iCol = 4
Output : 1 2 3 4
1 * * 4
1 * * 4
1 2 3 4
Program Layout 
*/

using System;

namespace Application
{
    class Program1
    {
        public static void Main(String[] arg)
        {
            int iValue1 = 0, iValue2 = 0;

            Console.WriteLine("Enter number Rows : ");
            iValue1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number Columns : ");
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
            for(int j = 1,iCnt = 1; j <= iCol; iCnt++, j++)
            {
                if((i==1)||(j==1)||(i==iRow)||(j==iCol))
                {
                    Console.Write(" "+iCnt);
                }
                else
                {
                    Console.Write(" *");
                }
            }
            Console.WriteLine(" ");
        }
    }
}