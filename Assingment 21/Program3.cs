/*
Accept character from user. If it is capital then display all the 
characters from the input characters till Z. If input character is small 
then print all the characters in reverse order till a. In other cases 
return directly.
Input : Q
Output : Q R S T U V W X Y Z
Input : m
Output : m l k j i h g f e d c b a
Input : 8
Output 
*/

using System;

namespace Application
{
	class Program3
	{
		public static void Main(String[] arg)
		{
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
		}
	}
}

class StringX
{
	public char ch;

	public void Accept()
	{
		Console.WriteLine("Enter character :");
		ch = char.Parse(Console.ReadLine());
	}
}

class Lucifer : StringX 
{
	public void Display()
	{
		Console.WriteLine("Output is : ");
		if((ch >= 'A') && (ch <= 'Z'))
		{
			while(ch != '[')
			{
				Console.WriteLine(ch);
				ch++;
			}
		}
		else if((ch >= 'a') && (ch <= 'z'))
		{
			while(ch != 'a'-1)
			{
				Console.WriteLine(ch);
				ch--;
			}
		}
		else{
			Console.WriteLine(" ");
		}
	}
}