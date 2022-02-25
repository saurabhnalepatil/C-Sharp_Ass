using System;

namespace Application
{
	class Program4
	{
		public static void Main(String[] args)
		{
			Lucifer obj = new Lucifer();
			obj.AcceptNum();
			obj.ProductR();
		}
	}
}

class Lucifer
{ 
	public static int value,iMult = 1,i =1;
	public void AcceptNum()
	{
		Console.WriteLine("Enter the number :");
		value = int.Parse(Console.ReadLine());
	}
	public void Product()
	{
		int iDigit = 0;
		while(value != 0)
		{
			iDigit = value % 10;
			iMult = iMult * iDigit;
			value = value / 10;
		}
		Console.WriteLine("Number of Digit Product is -> "+iMult);
	}
	public void ProductR()
	{	
		int iDigit = 0;
		if(value != 0)
		{
			iDigit = value % 10;
			iMult = iMult * iDigit;
			value = value / 10;
			ProductR();
		}
		else{
			Console.WriteLine("Number of Digit Product is -> "+iMult);
		}
	}
}
