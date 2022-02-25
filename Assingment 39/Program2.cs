/*Write C# program which accept String from user and display 
below pattern.
Input : Hello
Output : 
H e l l o
H e l l *
H e l * *
H e * * *
H * * * *
Program Layout : 
*/
using System;

namespace Application
{
	class Program2
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
		Console.WriteLine("Enter the String : ");
		str = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Pattern is : ");
	}
}

class Lucifer : StringX
{
	public void Pattern()
	{
		int len = str.Length;
		char[] Arr = str.ToCharArray();
		for(int i = len; i > 0; i--)
		{
			for(int j = 0; j < len; j++)
			{
				if(i <= j){
					Console.Write(" *");
				}
				else{
					Console.Write(" "+Arr[j]);
				}
			}
			Console.WriteLine(" ");
		}
	}
}