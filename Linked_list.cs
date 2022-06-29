using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    public class linked_list
    {
        internal Node head;
        public void create(int a)               //creating a node with data
        {
            Node node = new Node(a);
            this.head = node;
            Console.WriteLine("Node created with " + head.data);
        }
        public void add(int b)                  //adding a node in the begining
        {
            Node node = new Node(b);
            Node temp = head;
            temp.next = head.next;
            head = node;
            head.next = temp;
            Console.WriteLine("Node added with data " + head.data);
        }
        public void append(int a)           //adding nodes to the end
        {
            Node node = new Node(a);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine("Node appended with data " + temp.next.data);
        }
        public void insert(int inser,int position)              //adding nodes to a particular position
        {
            Node node = new Node(inser);
            Node temp = head;
            int posi = 1;
            if (position < 1)
            {
                Console.WriteLine("Wrong position");
            }
            else if(position==1)
            {
                Node newNode = node;
                newNode.next = temp;
                head = newNode;
                Console.WriteLine("Inserted new node with data " + newNode.data);
            }
            else
            {
                while (posi != position - 1)
                {
                    temp = temp.next;
                    posi++;
                }
                Node newNode = node;
                newNode.next = temp.next;
                temp.next=newNode;
                Console.WriteLine("Inserted new node with data "+newNode.data);
            }
        }
         public void print()                //printing the nodes
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
