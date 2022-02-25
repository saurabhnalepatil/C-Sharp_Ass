/*
Write a program which returns addition of all even element from singly 
linear linked list. 
Function Prototype :
int AdditionEven( PNODE Head); 
Input linked list : |11|->|20|->|32|->|41| 
Output : 52
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
			int iRet = obj.SumNodeEle();
			Console.WriteLine("Sum of All element of linkList :-> "+iRet);
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
	public int SumNodeEle()
	{
		Node temp = first;
		int iSum = 0;
		//Console.WriteLine("Replace to Node element to Sum of element Digit :");
		while(temp != null){
			if((temp.data % 2) == 0){
				iSum = iSum + temp.data;
			}
			temp = temp.next;
		}
		return iSum;
	}
}