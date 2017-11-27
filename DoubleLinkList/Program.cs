using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool quit = false;

            //create list and add nodes
            DoublyLinkedListImpl<int> dll = new DoublyLinkedListImpl<int>();
            dll.addHead("Unit 5, 19 Baxter St");
            dll.addHead("1 Jerramunga Rd");
            dll.addLast("3 Sophtis Cres");
            dll.addLast("4 Julie Rd");
            dll.addLast("5 EndofList St");

            while(!quit)
            {
                Console.WriteLine();
                Console.WriteLine("Menu Commands:");
                Console.WriteLine();
                Console.WriteLine("search - search for node");
                Console.WriteLine("add head - add node to head");
                Console.WriteLine("add tail - add node to tail");
                Console.WriteLine("delete head - delete head node");
                Console.WriteLine("delete tail - delete tail node");
                Console.WriteLine("replace - replace node value");
                Console.WriteLine("show - show entire link list");
                Console.WriteLine("show reverse - show entire link list (backwards)");
                Console.WriteLine("delete - show entire link list");
                Console.WriteLine("quit - exit program");
                Console.WriteLine();
                Console.Write("Enter menu command: ");
                string input = Console.ReadLine();
                input = input.ToLower();
                Console.WriteLine();
                if (input == "search")
                {
                    dll.findNode();
                }
                else if (input == "delete head")
                {
                    dll.removeFirst();
                }
                else if (input == "delete tail")
                {
                    dll.removeLast();
                }
                else if (input == "replace")
                {
                    dll.replaceNode();
                }
                else if (input == "show")
                {
                    dll.iterateForward();
                }
                else if (input == "show reverse")
                {
                    dll.iterateBackward();
                }
                else if (input == "back")
                {
                    dll.iterateBackward();
                }
                else if (input == "add head")
                {
                    string headinput;
                    headinput = Console.ReadLine();
                    dll.addHead(headinput);
                }
                else if (input == "add tail")
                {
                    string headinput;
                    headinput = Console.ReadLine();
                    dll.addLast(headinput);
                }
                else if (input == "quit")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Please type an authentic menu command!");
                }
            }

        }
    }

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
            Node tmp = new Node(data, head, null);
            if (head != null)
            {
                head.prev = tmp;
            }
            head = tmp;
            if (tail == null)
            {
                tail = tmp;
            }
            //increment list
            size++;
        }

        public void addLast(string element)
        {
            Node tmp = new Node(element, null, tail);
            if (tail != null)
            {
                tail.next = tmp;
            }
            else
            {
                tail.prev = tmp;
            }
            tail = tmp;
            if (head == null)
            {
                head = tmp;
            }
            size++;
        }

        public void findNode()
        {
            Console.WriteLine("Enter node to search: ");
            string userSearch = Console.ReadLine();
            Node tmp = head;
            while (tmp != null)
            {
                if (userSearch == tmp.data)
                {
                    Console.WriteLine("Node found: " + tmp.data);
                    tmp = null;
                }
                else
                {
                    tmp = tmp.next;
                }
            }
        }

        public void replaceNode()
        {
            Console.WriteLine("Enter node to replace: ");
            string userSearch = Console.ReadLine();
            Node tmp = head;
            while (tmp != null)
            {
                if (userSearch == tmp.data)
                {
                    Console.WriteLine("Enter replacement value for node: ");
                    string replacement = Console.ReadLine();
                    tmp.data = replacement;
                    Console.WriteLine("New node value: " + tmp.data);
                    tmp = null;
                }
                else
                {
                    tmp = tmp.next;
                }
            }
        }

        public void iterateForward()
        {
            Console.WriteLine("iterating forward..");
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }          
        }

        public void iterateBackward()
        {
            Console.WriteLine("iterating backwards..");
            Node tmp = tail;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.prev;
            }
        }

        public string removeFirst()
        {
            Node tmp = head;
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
                    Console.WriteLine("deleted: " + tmp.data);
                    Console.WriteLine("Can't delete anymore!");
                }
                else
                {
                    head.prev = null;
                    size--;
                    Console.WriteLine("deleted: " + tmp.data);
                }
            }
            return tmp.data;
        }

        //remove last link list entry
        public string removeLast()
        {
            Node tmp = tail;
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
                    Console.WriteLine("deleted: " + tmp.data);
                    Console.WriteLine("Can't Delete anymore!");
                }
                else
                {
                    tail.next = null;
                    size--;
                    Console.WriteLine("deleted: " + tmp.data);
                }      
            }
            return tmp.data;
        }
    }
}
