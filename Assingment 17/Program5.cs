/*
Accept N numbers from user and accept one another number as NO , 
return frequency of NO form it.
Input : N : 6
NO: 66
Elements :85 66 3 66 93 88
Output : 2
Input : N : 6
NO: 12
Elements :85 11 3 15 11 111
Output : 0
Program Layout : 
*/
using System;

namespace Application
{
    class Program5
    {
        public static void Main(String[] arg)
        {
            Console.WriteLine("Enter number of Elements : ");
            int iLen = int.Parse(Console.ReadLine());

            Lucifer obj = new Lucifer();
            obj.MemoryArr(iLen);
            obj.AcceptArr();
            obj.AcceptValue();
            int iRet = obj.Freq();

            Console.WriteLine("Frequency of is : "+iRet);
        }
    }
}
class ArrayX
{
    public int[] Arr;public int iValue;
    public void MemoryArr(int iSize)
    {
        Arr = new int[iSize];
    }
    public void AcceptArr()
    {
        Console.WriteLine("Enter number "+ Arr.Length + " Elements : ");
        for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
        {
            Arr[iCnt] = int.Parse(Console.ReadLine());
        }
    }
    public void AcceptValue()
    {
        Console.WriteLine("Enter Check Freq of No : ");
        iValue = int.Parse(Console.ReadLine());

    }
}
class Lucifer : ArrayX
{
    public int Freq()
    {
        int iCount = 0;
        for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
        {
            if(Arr[iCnt] == iValue) 
            {
                iCount++;
            }
        }
        return iCount;
    }
}