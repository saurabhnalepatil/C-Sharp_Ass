/*Accept number from user and display below pattern.
Input : 5
Output : 5 # 4 # 3 # 2 # 1 #
Program Layout :
*/
using System;

namespace Appication
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;

			Console.WriteLine("Enter number : ");
			iValue = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.Pattern(iValue);
		}
	}
}

class Lucifer
{
	public void Pattern(int iNo)
	{
		int iCnt = 0;

		for(iCnt = iNo; iCnt >= 1; iCnt--)
		{
			Console.Write(iCnt+" # ");
		}
	}
}