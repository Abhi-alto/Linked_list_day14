using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
       public class linked_list
        {
<<<<<<< HEAD
            Node node = new Node(a);
            this.head = node;
            Console.WriteLine("Node created with "+head.data);
        }
        public void add(int a)
        {
             Node node = new Node(a);
             Node temp = head;
             while (temp.next != null)
             {
                 temp = temp.next;
             }
            temp.next = node;
            Console.WriteLine("Node added with data " + temp.next.data);

        }
        public void append(int a)
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
        public void print()
        {
            Node temp = this.head;
            while (temp != null)
=======
            internal Node head;
            public void create(int a)
>>>>>>> addToList
            {
                Node node = new Node(a);
                this.head = node;
                Console.WriteLine("Node created with " + head.data);
            }
            public void add(int b)
            {
                Node node = new Node(b);
                Node temp = head;
                temp.next = head.next;
                head = node;
                head.next = temp;
                Console.WriteLine("Node added with data " + head.data);
            }
            public void print()
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
