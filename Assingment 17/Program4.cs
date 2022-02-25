/*
Accept N numbers from user and return frequency of 11 form it.
Input : N : 6
Elements :85 66 3 15 93 88
Output : 0
Input : N : 6
Elements :85 11 3 15 11 111
Output : 2
*/

using System;

namespace Application
{
    class Program4
    {
        public static void Main(String[] arg)
        {
            Console.WriteLine("Enter number of Elements : ");
            int iLen= int.Parse(Console.ReadLine());

            Lucifer obj = new Lucifer();
            obj.MemoryArr(iLen);
            obj.AcceptArr();
            int iRet = obj.Freq();

            Console.WriteLine("Frequency of 11 No : "+iRet);
        }
    }
}
class ArrayX
{
    public int[] Arr;
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
}
class Lucifer : ArrayX
{
    public int Freq()
    {
        int iCount = 0;
        for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
        {
            if(Arr[iCnt] == 11) 
            {
                iCount++;
            }
        }
        return iCount;
    }
}