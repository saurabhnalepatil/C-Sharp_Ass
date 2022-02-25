/*
Accept character from user. If character is small display its 
corresponding capital character, and if it small then display its 
corresponding capital. In other cases display as it is.
Input : Q
Output : q
Input : m
Output : M
Input : 4
Output : 4
Input : %
Output : %
*/

using System;

namespace Application
{
	class Program2
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
	public char str;

	public void Accept()
	{
		Console.WriteLine("Enter Character : ");
		str = char.Parse(Console.ReadLine());
	}
}

class Lucifer : StringX
{
	public void Display()
	{
		int ascii = 0;
		//char[] Arr = str.toCharArray();
		//char ch = str.charAt(0);
		if((str >= 'A') && (str <= 'Z'))
		{
			ascii = str;
			ascii = ascii + 32;
			str = (char)ascii;
			Console.WriteLine("Uppercase to Lowercase Alphabet : "+str);
			return;
		}
		else if((str >= 'a') && (str <= 'z'))
		{
			ascii = str;
			ascii = ascii - 32;
			str = (char)ascii;
			Console.WriteLine("Lowercase to Uppercase Alphabet : "+str);
			return;
		}
		else{
			Console.WriteLine("Character Not Convertable : "+str);
		}
	}
}