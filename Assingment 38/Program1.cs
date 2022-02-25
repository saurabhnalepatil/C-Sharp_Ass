/*
Write C# program which accept String from user and display 
below pattern.
Input : Hello
Output : 
H e l l o
H e l l o
H e l l o
H e l l o
Program Layout : 
*/

using System;

namespace Appliction
{
	class Program1
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
		int i , j ; 
		int len = str.Length;
		char[] ch = str.ToCharArray();

		Console.WriteLine("Pattern is : ");

		for(j = 0; j <= len; j++)
		{
			for(i = 0; i <= len; i++)
			{
				Console.Write(" "+ch[j]);
			}
			Console.WriteLine(" ");
		}
		
	}
}