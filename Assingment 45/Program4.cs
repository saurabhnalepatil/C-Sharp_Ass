/*
Write a program which display smallest digits of all element from singly 
linear linked list.
Function Prototype :
void DisplaySmall( PNODE Head); 
Input linked list : |11|->|250|->|532|->|415| 
Output : 1 0 2 1
*/

using System;

namespace Application
{
	class Program4
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
			obj.SmallestDigit();
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
	public void SmallestDigit()
	{
		int iDigit = 0, iMin = 0;
		Node temp = first;
		Console.WriteLine("Smallest Digit Replace to node element :");
		
		while(temp != null){

			Console.Write("|");
			while(temp.data != 0)
			{
				iDigit = temp.data % 10;
				if(iMin < 1){
					iDigit = iMin;
				}
				else if(iDigit < iMin){
					iDigit = iMin;
				}
				temp.data = temp.data / 10;
			}
			Console.Write(iMin+"|-> ");
			temp = temp.next;
			iMin = 0;
		}
		Console.Write("null\n");
	}
}