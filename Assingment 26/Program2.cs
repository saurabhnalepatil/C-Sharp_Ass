using System;

namespace Application
{
	class Program3
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept1();
			obj.Display();
			obj.RemSpace();
		}
	}
}

class StringX 
{
	public String str1;

	public void Accept1()
	{
		Console.WriteLine("Enter String : ");
		str1 = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Remove of Space in String Line : ");
	}
}

class Lucifer : StringX
{
	public void RemSpace()
	{
		for(int i = 0; i < str1.Length; i++)
		{
			char ch = str1[i];
			if(ch != ' ')
			Console.Write(ch);
		}
	}
}