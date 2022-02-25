/*
Write a program which display addition of digits of element from singly 
linear linked list. 
Function Prototype :int SumDigit( PNODE Head); 
Input linked list : |110|->|230|->|20|->|240|->|640| 
Output : 2 5 2 6 10
*/

using System;

namespace Application
{
	class Program5
	{
		public static void Main(String[] args)
		{
			Singly_LinkList obj = new Singly_LinkList();
			Console.WriteLine("Enter the number of element insert no.");
			int size = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter "+size+" element :");
			for(int i = 1; i <= size; i++)
			{
				Console.WriteLine("Enter the element :"+i +"-> ");
				int value = int.Parse(Console.ReadLine());
				obj.InsertLast(value);
			}
			obj.Display();
			obj.SumDigit();
		}
	}
}

class Node
{
	public int data;
	public Node next;
}

class Singly_LinkList
{
	private Node first;
	private int size;

	public Singly_LinkList()
	{
		this.first = null;
		this.size = 0;
	}
	public void InsertLast(int no)
	{
		Node newn = null;
		newn = new Node();

		newn.data = no;
		newn.next = null;

		if(first == null){
			first = newn;
		}
		else{
			Node temp = first;
			while(temp.next != null){
				temp = temp.next;
			}
			temp.next = newn;
		}
		this.size++;
	}
	public void Display()
	{
		Node temp = first;
		Console.WriteLine("element from linked list are :");

		while(temp != null){
			Console.Write("|"+temp.data+"|-> ");
			temp = temp.next;
		}
		Console.Write("null\n");
	}
	public void SumDigit()
	{
		Node temp = first;
		int iSum = 0, iDigit = 0; 
		Console.WriteLine("Replace to Node element to Sum of element Digit :");
		while(temp != null){

			while(temp.data != 0)
			{
				iDigit = temp.data % 10;
				iSum = iSum + iDigit;
				temp.data = temp.data / 10;
			}
			Console.Write("|"+iSum+"|-> ");
			temp = temp.next;
			iSum = 0;
		}
		Console.Write("null\n");
	}
}