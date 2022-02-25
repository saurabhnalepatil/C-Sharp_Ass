/*
Write a program which return second maximum element from singly linear 
linked list. 
Function Prototype :
int SecMaximum( PNODE Head); 
Input linked list : |110|->|230|->|320|->|240| 
Output : 240
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
			int iRet = obj.SecondMax();
			Console.WriteLine("Second Largest no in linked list:-> "+iRet);
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
	public int SecondMax()
	{
		Node temp = first;
		Node temp1 = first;
		int iMax = 0; 
		//Console.WriteLine("Replace to Node element to Sum of element Digit :");
		temp.data = iMax;
		while(temp != null){

			if(temp.data > iMax){
				iMax = temp.data;
			}
			temp = temp.next;
		}
		while(temp1 != null){
			if(temp1.data > iMax){
				
			}
			temp1 = temp1.next;

		}
	}
}