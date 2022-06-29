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
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                head = node;
                Console.WriteLine("Node appended with data " + head.data);
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Node appended with data " + temp.next.data);
            }
        }
        public void search(int find)            //searching for a particular node
        {
            Node node = new Node(find);
            Node temp = head;
            int position = 1;
            bool present = true;
            if (head == null )                  //if there is no node
            {
                Console.WriteLine("Element not present"); 
            }
            else                                
            {
                while (temp.data != find )                  
                {
                    if (temp.next == null)                  //if we are at the last node
                    {
                        present = false;
                        break;
                    }
                    temp = temp.next;
                    position++;
                }
                if (present)
                {
                    position++;
                    Console.WriteLine("Position of  the searched node is " + position);
                }
                else
                    Console.WriteLine("Element not present");
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
