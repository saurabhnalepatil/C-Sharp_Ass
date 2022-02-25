/*
Write Java program which accept array of characters from user and 
replace each capital character with its corresponding small character.
Input : b N e B R b A i G i
Output : 
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Enter first array length :");
			int iLen1 = int.Parse(Console.ReadLine());

			Lucifer obj = new Lucifer();
			obj.AcceptLen(iLen1);
			obj.AccceptArr();
			obj.ReplaceCaptital();
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
	public void ReplaceCaptital()
	{	
		Console.WriteLine("Replace Array element small later to captital :");
		for(int i = 0; i < Arr.Length; i++)
		{
			if((Arr[i] >= 'a')&&(Arr[i] <= 'z'))
			{
				Arr[i] = (char)(Arr[i]+'A' - 'a');
				Console.Write(Arr[i]+" ");
			}
			else{
				Console.Write(Arr[i]+" ");
			}
		}
	}	
}