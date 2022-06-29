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
        public void deleteFirst()                   //deleting the first node
        {
            Console.WriteLine("First element is "+head.data);
            Node temp = head;
            if (temp != null)
                head = temp.next;
            else
                Console.WriteLine("LinkedList is empty");

        }
        public void deleteLast()                   //deleting the last node
        {
            Node temp = head;

            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else if (head.next == null)
            {
                Console.WriteLine("The last element is " + temp.data);
                head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("The last element is " + temp.next.data);
                temp.next = null;
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
