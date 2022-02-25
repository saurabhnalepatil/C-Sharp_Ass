/*
Write a java program which accept string from user and check 
whether it contains vowels in it or not.
Input : “marvellous”
Output : TRUE
Input : “Demo”
Output : TRUE
Input : “xyz”
Output : FALSE
*/

using System;

namespace Application
{
	class Program4
	{
		public static void Main(string[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			bRet = obj.ChkVowelX();
			if(bRet == true){
				Console.WriteLine("Vowel is Present");
			}
			else{
				Console.WriteLine("Vowel is Absent");
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
}

class Lucifer : StringX
{
	public bool ChkVowelX()
	{
		bool bAns = false;
		//char[] Arr =str.ToCharArray();
		//foreach(char ch in Arr)
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			if((ch=='a')||(ch=='e')||(ch=='i')||(ch=='u')||(ch=='o'))
			{
				bAns = true;
			}
		}
		return bAns;
	}
}