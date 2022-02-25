/*
Write a program which display product of all digits of all element from 
singly linear linked list. (Don’t consider 0) 
Function Prototype :
void DisplayProduct( PNODE Head); 
Input linked list : |11|->|20|->|32|->|41| 
Output : 1 2 6 4
*/

using System;

namespace Application
{
	class Program3
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
			obj.ReplacePro();
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
	public void ReplacePro()
	{
		int iDigit = 0, iMult = 1;
		Node temp = first;
		Console.WriteLine("Replace a linked element to that element digit Product :");

		while(temp != null){
			Console.Write("|");
			while(temp.data != 0)
			{
				iDigit = temp.data % 10;
				iMult = iMult * iDigit;
				temp.data = temp.data / 10;
			}
			Console.Write(iMult+"|-> ");
			temp = temp.next;
			iMult = 1;
		}
		Console.Write("null\n");
	}
}