/*
Write Java program which accept String from user and display 
below pattern.
Input : Hello
Output : 
H e l l o
H e l l
H e l
H e
H
Program Layout : 
*/

using System;

namespace Appliction
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			string str;

			Console.WriteLine("Enter String : ");
			str = Console.ReadLine().Trim().ToUpper();

			Lucifer obj = new Lucifer();
			obj.Pattern(str);
		}
	}
}

class Lucifer
{
	public void Pattern(string str)
	{
		int len = str.Length;
		//char[] ch = str.ToCharArray();

		Console.WriteLine("Pattern is : ");
		for(int i = len; i >= 1; i--)
		{
			for(int j = 0; j < len; j++)
			{
				char[] ch = str.ToCharArray();
				char[] chh = new char[j];
				if(i > j)
				{
					Console.Write(" "+chh);
				}
				else
				{
					Console.Write(" ");
				}			
			}
			Console.WriteLine("");
		}
	}
}