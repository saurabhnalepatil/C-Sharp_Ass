/*
Write C# program which accept String from user and display 
below pattern.
Input : Hello
Output : 
H # # # #
H e # # #
H e l # #
H e l l #
H e l l o
H e l l #
H e l # #
H e l # #
H e # # #
H # # # #
Program Layout :
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(string[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
			obj.Pattern();
		}
	}
}


class StringX 
{
	public string str;

	public void Accept()
	{
		Console.WriteLine("Enter the String :");
		str = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Pattern is :");
	}
}

class Lucifer : StringX 
{
	public void Pattern()
	{
		char[] Arr = str.ToCharArray();
		for(int i = 0; i < str.Length; i++)
		{
			for(int j = 0; j < str.Length; j++)
			{
				if(i >= j){
					Console.Write(" "+Arr[j]);
					}
				else{
					Console.Write(" #");
				}
			}
			Console.WriteLine(" ");
		}
		for(int i = str.Length -1; i > 0; i--)
		{
			for(int j = 0; j < str.Length; j++)
			{
				if(i > j){
					Console.Write(" "+Arr[j]);
					}
				else{
					Console.Write(" #");
				}
			}
			Console.WriteLine(" ");
		}
	}
}