/*
Write a program which accept string from user and accept one 
character. Check whether that character is present in string or not.
Input : “Marvellous Multi OS”
e
Output : TRUE
Input : “Marvellous Multi OS”
W
Output : FALSE
*/
using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			bRet = obj.CheckVowel();
			obj.Display();
			if(bRet == true)
			{
				Console.WriteLine("Vowel is Present in String");
			}
			else{
				Console.WriteLine("Vowel is Absend in String");
			}
		}
	}
}

class StringX 
{
	public String str;

	public void Accept()
	{
		Console.WriteLine("Enter String : ");
		str = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Chech whether vowel Present or Not : ");
	}
}

class Lucifer : StringX
{
	public bool CheckVowel()
	{
		bool bAns = false;
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch=='a')||(ch=='e')||(ch=='i')||(ch=='o')||(ch=='u'))
			{
				bAns = true;
			}
		}
		return bAns;
	}
}