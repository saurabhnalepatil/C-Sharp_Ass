/*
Write a program which 2 strings from user and check whether 
contents of two strings are equal or not.
Input :
“Marvellous Infosystems”
“Marvellous Infosystems”
Output : TRUE
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(string[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			obj.Display();
			bRet = obj.CprStr();

			if(bRet == true){
				Console.WriteLine("String are Match");
			}
			else{
				Console.WriteLine("String Not Match");
			}
		}
	}
}

class StringX
{
	public String str1,str2;

	public void Accept()
	{
		Console.WriteLine("Enter a First String :");
		str1 = Console.ReadLine();

		Console.WriteLine("Enter a Second String :");
		str2 = Console.ReadLine();
	}
	public void Display()
	{
		Console.WriteLine("Check Whether Compaire to String :");
	}
}

class Lucifer : StringX
{
	public bool CprStr()
	{
		bool bAns = true;
		char[] strA = str1.ToCharArray();
		char[] strB = str2.ToCharArray();
		for(int i = 0,j = 0; i < str1.Length,j < Arr.Length;j++, i++)
		{
			//for(int j = 0; j < str2.Length; j++)
			{
				char sh = strB[j];
				if(ch != sh)
				{
					bAns = false;
				}
			}
		}
		return bAns;
	}
}