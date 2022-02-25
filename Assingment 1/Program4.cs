//Accept one number and check whether is is divisible by 5 or not. 


using System;

namespace CheckApp
{
	class Program4
	{
		public static void Main(string[] arg)
		{
			int iValue = 0;
			bool bRet = false;

			Console.WriteLine("Enter Number : ");
			iValue = Convert.ToInt32(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.Check(iValue);

			if(bRet == true)
			{
				Console.WriteLine("Divisible by 5");
			}
			else
			{
				Console.WriteLine("Not Divisible by 5");
			}
		}
	}
}

class Lucifer
{
	public bool Check(int iValue)
	{
		if((iValue % 5) == 0)
		{
			return true;
		}	
		else
		{
			return false;
		}
	}
}