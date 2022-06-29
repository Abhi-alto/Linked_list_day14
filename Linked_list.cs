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
        public void insert(int inser, int position)              //adding nodes to a particular position
        {
            Node node = new Node(inser);
            Node temp = head;
            int posi = 1;
            if (position < 1)
            {
                Console.WriteLine("Wrong position");
            }
            else if (position == 1)
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
                temp.next = newNode;
                Console.WriteLine("Inserted new node with data " + newNode.data);
            }
        }
        public int search(int find)            //searching for a particular node
        {
            Node node = new Node(find);
            Node temp = head;
            int position = 1;
            bool present = true;
            if (head == null )                  //if there is no node
            {
                return 0;
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
                    //Console.WriteLine("Position of  the searched node is " + position);
                    return position;
                }
                else
                    return 0;
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
