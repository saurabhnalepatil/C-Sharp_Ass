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
			bRet = obj.CheckVowel();

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
	public string str;

	public void Accept()
	{
		Console.WriteLine("Enter the String : ");
		str = Console.ReadLine();
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
			if((ch=='a')||(ch=='o')||(ch=='e')||(ch=='i')||(ch=='u'))
			{
				bAns = true;
			}
		}
		return bAns;
	}
}