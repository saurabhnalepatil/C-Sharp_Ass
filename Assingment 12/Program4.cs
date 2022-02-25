/*
Accept number of rows and number of columns from user and display below 
pattern.
Input : iRow = 6 iCol = 5
Output : 
* * * * *
* @ @ @ *
* @ @ @ *
* @ @ @ *
* @ @ @ *
* * * * *
Program Layout : 
*/

using System;

namespace Application
{
    class Program4
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
            for(int j = 1; j <= iCol; j++)
            {
                if((i==1)||(i==iRow)||(j==1)||(j==iCol))
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write(" @");
                }
            }
            Console.WriteLine(" ");
        }
    }
}