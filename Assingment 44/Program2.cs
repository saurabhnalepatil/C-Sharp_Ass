/*
Write a program which displays all elements which are prime from singly 
linear linked list. 
Function Prototype :
int DisplayPrime( PNODE Head); 
Input linked list : |11|->|20|->|17|->|41|->|22|->|89| 
Output : 11 17 41 89
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
			obj.PrimeNo();
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
	public void PrimeNo()
	{
		int i = 1;
		Node temp = first;
		Console.WriteLine("Prime number in LinkList :");
		
		while(temp != null){

			while(i < temp.data/2)
			{
				if((temp.data % i)== 0){
					iSum = iSum + i;
				}
				i++;
				if(iSum == temp.data){
					Console.Write("|"+iPrf+"|-> ");
				}
			}
			temp = temp.next;
		}
		Console.Write("null\n");
	}
}