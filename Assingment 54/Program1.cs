/*
Write Java program which accept array of characters from user and 
replace each capital character with its corresponding small character.
Input : b N j B R b A d G G
Output : b n j b r b a d g g
*/

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1);
			obj.AccceptArr();
			obj.Replacesmall();
		}
	}
}

class ArrayX
{
	public char[] Arr;
	public void AcceptLen(int size1)
	{
		Arr = new char[size1];
	}
	public void AccceptArr()
	{
		Console.WriteLine("Enter "+Arr.Length+" Element of Array :");
		for(int i = 0; i < Arr.Length; i++)
		{
			Arr[i] = Console.ReadLine()[0];
		}
	}
}

class Lucifer : ArrayX
{
	public void Replacesmall()
	{	
		Console.WriteLine("Replace Array element to capital small later :");
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] >= 'A')&&(Arr[i] <= 'Z'))
			{
				Arr[i] = (char)(Arr[i]+'a' - 'A');
				Console.Write(Arr[i]+" ");
			}
			else{
				Console.Write(Arr[i]+" ");
			}
		}
	}	
}