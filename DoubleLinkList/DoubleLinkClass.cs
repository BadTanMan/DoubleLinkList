using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    public class DoublyLinkedListImpl<a>
    {
        public bool noHeads = false;
        public bool noTails = false;
        private Node head;
        private Node tail;
        public int size { get; set; }

        public DoublyLinkedListImpl()
        {
            size = 0;
        }

        public class Node
        {
            public string data;
            public Node next;
            public Node prev;

            public Node(string data, Node next, Node prev)
            {
                this.data = data;
                this.next = next;
                this.prev = prev;
            }
        }

        //add to head of link list
        public void addHead(string data)
        {
            //prev node set to null (due to being head node)
            Node temp = new Node(data, head, null);
            if (head != null)
            {
                head.prev = temp;
            }
            head = temp;
            if (tail == null)
            {
                tail = temp;
            }
            //increment list
            size++;
        }

        public void addLast(string element)
        {
            Node temp = new Node(element, null, tail);
            if (tail != null)
            {
                tail.next = temp;
            }
            else
            {
                tail.prev = temp;
            }
            tail = temp;
            if (head == null)
            {
                head = temp;
            }
            size++;
        }

        public void findNode()
        {
            Console.WriteLine("Enter node to search: ");
            string userSearch = Console.ReadLine();
            Node temp = head;
            while (temp != null)
            {
                if (userSearch == temp.data)
                {
                    Console.WriteLine("Node found: " + temp.data);
                    temp = null;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        public void replaceNode()
        {
            Console.WriteLine("Enter node to replace: ");
            string userSearch = Console.ReadLine();
            Node temp = head;
            while (temp != null)
            {
                if (userSearch == temp.data)
                {
                    Console.WriteLine("Enter replacement value for node: ");
                    string replacement = Console.ReadLine();
                    temp.data = replacement;
                    Console.WriteLine("New node value: " + temp.data);
                    temp = null;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }

        public void iterateForward()
        {
            Console.WriteLine("iterating forward..");
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void iterateBackward()
        {
            Console.WriteLine("iterating backwards..");
            Node temp = tail;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.prev;
            }
        }

        public string removeFirst()
        {
            Node temp = head;
            if (noHeads == true)
            {
                Console.WriteLine("Can't Delete anymore!");
            }
            else
            {
                head = head.next;
                if (head.next == null)
                {
                    noHeads = true;
                    Console.WriteLine("deleted: " + temp.data);
                    Console.WriteLine("Can't delete anymore!");
                }
                else
                {
                    head.prev = null;
                    size--;
                    Console.WriteLine("deleted: " + temp.data);
                }
            }
            return temp.data;
        }

        //remove last link list entry
        public string removeLast()
        {
            Node temp = tail;
            if (noTails == true)
            {
                Console.WriteLine("Can't Delete anymore!");
            }
            else
            {
                //set end node to prev
                tail = tail.prev;
                if (tail.prev == null)
                {
                    noTails = true;
                    Console.WriteLine("deleted: " + temp.data);
                    Console.WriteLine("Can't Delete anymore!");
                }
                else
                {
                    tail.next = null;
                    size--;
                    Console.WriteLine("deleted: " + temp.data);
                }
            }
            return temp.data;
        }
    }
}
