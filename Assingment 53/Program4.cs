/*
Write java program which accept marks of N students from user 
and display class of each student.
Less than 35 - Fail
Less than 50 - Pass class
Less than 60 - Second class
Less than 70 - First class
Greater than 70 - First class with Distinction
Input : 67.3 45.8 88.9 77.5 55.2
Output : 67.3 First class
45.8 Pass class
88.9 First class with Distinction
77.5 First class with Distinction
55.2 Second class
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
			obj.ResultDis();
		}
	}
}

class ArrayX
{
	public float[] Arr;
	public void AcceptLen(int size1)
	{
		Arr = new float[size1];
	}
	public void AccceptArr()
	{
		Console.WriteLine("Enter "+Arr.Length+" Element of Array :");
		for(int i = 0; i < Arr.Length; i++)
		{
			Arr[i] = float.Parse(Console.ReadLine());
		}
	}
}

class Lucifer : ArrayX
{
	public void ResultDis()
	{

		Console.WriteLine("Result Element in Array Marks of student ->");
		for(int i = 0; i < Arr.Length; i++)
		{
			if(Arr[i] <= 35.0){
				Console.WriteLine(Arr[i]+" -> Fail");
			}
			else if((Arr[i] >= 35)&&(Arr[i] <= 50))
			{
				Console.WriteLine(Arr[i]+" -> Pass Class");
			}
			else if((Arr[i] >= 50)&&(Arr[i] <= 60))
			{
				Console.WriteLine(Arr[i]+" -> First Class");
			}
			else if((Arr[i] >= 60)&&(Arr[i] <= 70))
			{
				Console.WriteLine(Arr[i]+" -> First Class with Distinction");
			}
			else if((Arr[i] >= 70)&&(Arr[i] <= 100))
			{
				Console.WriteLine(Arr[i]+" -> First Class with Distinction");
			}
		}
	}	
}