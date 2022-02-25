 //Accept one number from user and print that number of * on screen. 

 using System;

 namespace AcceptApp
 {
    class Program5
    {
        public static void Main(String[] arg)
        {
            int iValue = 0;

            Console.WriteLine("Enter number : ");
            iValue = Convert.ToInt32(Console.ReadLine());

            Lucifer obj = new Lucifer();
            obj.Accept(iValue);
        }
    }
 }

 class Lucifer
 {
    public void Accept(int iNo)
    {
        int iCnt = 0;
        for(iCnt = 1; iCnt <= iNo; iCnt++)
        {
            Console.WriteLine(" * ");
        }
    }
 }