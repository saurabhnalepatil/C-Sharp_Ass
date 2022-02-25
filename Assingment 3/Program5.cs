/*
Accept on character from user and check whether that character is vowel 
(a,e,i,o,u) or not. 
Input : E Output : TRUE 
Input : d Output : FALSE 
*/

using System;

namespace CheckVowelApp
{
	class Program5
	{
		public static void Main(String[] arg)
		{
			char ctr;
			bool bRet = false;

			Console.WriteLine("Enter character : ");
			ctr = Convert.ToChar(Console.ReadLine());

			Lucifer obj = new Lucifer();
			bRet = obj.CheckVowel(ctr);

			if(bRet == true)
			{
				Console.WriteLine(" It is Vowel ");
			}
			else
			{
				Console.WriteLine(" It is Not Vowel ");
			}
		}
	}
}

class Lucifer
{
	public bool CheckVowel(char cV)
	{
		if((cV=='A')||(cV=='I')||(cV=='E')||(cV=='U')||(cV=='O')||(cV=='a')||(cV=='i')||(cV=='e')||(cV=='o')||(cV=='u'))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}