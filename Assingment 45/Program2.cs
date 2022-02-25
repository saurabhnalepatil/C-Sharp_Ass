/*
Write a program which display all palindrome elements of singly linked 
list. 
Function Prototype :
void DisplayPallindrome( PNODE Head); 
Input linked list : |11|->|28|->|17|->|414|->|6|->|89| 
Output : 11 6 414
*/

using System;

namespace Application
{
	class Program2
	{
		public static void Main(String[] args)
		{
			Singly_Linear_LinkList obj = new Singly_Linear_LinkList();
			Console.WriteLine("Enter the number of Elements insert no.");
			int size = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the "+size+" Elements :");
			for(int i = 1; i <= size; i++)
			{
				Console.WriteLine("Enter the element :"+i +"-> ");
				int value = int.Parse(Console.ReadLine());
				obj.InsertLast(value);
			}
			obj.Display();
			int iRet = obj.Count();
			Console.WriteLine("\nNumber of node in LinkedList : "+iRet);
			obj.Palidrome();
		}
	}
}

class Node
{
	public int data;
	public Node next;
}

class Singly_Linear_LinkList
{
	private Node first;
	private int size;

	public Singly_Linear_LinkList()
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
			while(temp.next != null)
			{
				temp = temp.next;
			}
			temp.next = newn;
		}
		this.size++;
	}
	public void Display()
	{
		Node temp = first;
		Console.WriteLine("Elements from linked list are : \n");

		while(temp != null){
			Console.Write("|"+temp.data+"|-> ");
			temp = temp.next;
		}
		Console.Write("null\n");
	}
	public int Count(){
		return this.size;
	}
	public void Palidrome()
	{
		int iDigit = 0,iNo = 0,Check = 0;
		Node temp = first;
		Console.WriteLine("Element of Palidrome : ");

		while(temp != null){
			Console.Write("|");
			
			while(temp.data != 0)
			{
				temp.data = Check;
				iDigit = temp.data % 10;
				//Console.Write(iDigit);
				iNo = (iNo * 10)+iDigit;
				temp.data = temp.data / 10;			 
			}
			if(iNo == Check){
				Console.Write(Check);
			}
			Console.Write("|-> ");
			temp = temp.next;
		}
		Console.Write("null\n");
	}
}