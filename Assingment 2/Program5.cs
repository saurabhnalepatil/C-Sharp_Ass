//Accept number from user and check whether number is even or odd.

using System;

namespace DisplayApp
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			int iValue = 0;
			bool bRet = false;

			Console.WriteLine("Enter number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.Display(iValue);

			if(bRet == true)
			{
				Console.WriteLine("Given No is Even ");
			}
			else
			{
				Console.WriteLine("Given No is Odd ");
			}
		}
	}
}

class Lucifer
{
	public bool Display(int iNo)
	{
		if((iNo % 2) == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
