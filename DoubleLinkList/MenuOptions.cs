using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    class MenuOptions
    {
        public void showMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu Commands:");
            Console.WriteLine();
            Console.WriteLine("DOUBLE LINK LIST OPTIONS");
            Console.WriteLine("search - search for node");
            Console.WriteLine("add head - add node to head");
            Console.WriteLine("add tail - add node to tail");
            Console.WriteLine("delete head - delete head node");
            Console.WriteLine("delete tail - delete tail node");
            Console.WriteLine("replace - replace node value");
            Console.WriteLine("show - show entire link list");
            Console.WriteLine("show reverse - show entire link list (backwards)");
            Console.WriteLine("delete - show entire link list");
            Console.WriteLine();
            Console.WriteLine("BINARY TREE OPTIONS");
            Console.WriteLine("create binary tree - create a binary tree that sorts itself");
            Console.WriteLine("quit - exit program");
            Console.WriteLine();
            Console.Write("Enter menu command: ");
        }
    }
}
