/*
Write a program which displays all elements which are perfect from singly 
linear linked list. 
Function Prototype :
int DisplayPerfect( PNODE Head); 
Input linked list : |11|->|28|->|17|->|41|->|6|->|89| 
Output : 6 28
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
			obj.PerfectNo();
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
	public void PerfectNo()
	{
		Node temp = first;
		int iSum = 0, i = 1,tmp = 0; 
		while(temp != null){

			while(i < temp.data)
			{
				tmp = temp.data;
				if((temp.data % i)== 0){
					iSum = iSum + i;
					Console.Write("|"+iSum+"|-> ");
				}
				i++;
				if(iSum == tmp){
					Console.Write("|"+tmp+"|-> ");
				}
			}
			temp = temp.next;
		}
		Console.Write("null\n");
	}
}