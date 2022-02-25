/*Write a program which display largest digits of all element from singly 
linear linked list.
Function Prototype :
void DisplayLarge( PNODE Head); 
Input linked list : |11|->|250|->|532|->|419| 
Output : 1 5 5 9
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
			obj.LargestDigit();
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
	public void LargestDigit()
	{
		int iDigit = 0, iMax = iDigit;
		Node temp = first;
		Console.WriteLine("Smallest Digit Replace to node element :");
		
		while(temp != null){

			Console.Write("|");
			while(temp.data != 0)
			{
				iDigit = temp.data % 10;
				if(iDigit > iMax){
					iDigit = iMax;
				}
				temp.data = temp.data / 10;
			}
			Console.Write(iMax+"|-> ");
			temp = temp.next;
		}
		Console.Write("null\n");
	}
}