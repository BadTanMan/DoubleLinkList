using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add binary tree
//search binary tree
//

namespace DoubleLinkList
{
    class Program
    { 
        static void Main(string[] args)
        {
            Tree newTree;
            bool quit = false;

            //create list and add nodes
            DoublyLinkedListImpl<int> myLinkList = new DoublyLinkedListImpl<int>();
            myLinkList.addHead("Unit 5, 19 Baxter St");
            myLinkList.addHead("1 Jerramunga Rd");
            myLinkList.addLast("3 Sophtis Cres");
            myLinkList.addLast("4 Julie Rd");
            myLinkList.addLast("5 EndofList St");

            while(!quit)
            {
                MenuOptions menu = new MenuOptions();
                menu.showMenu();
                string input = Console.ReadLine();
                input = input.ToLower();
                Console.WriteLine();
                if (input == "search")
                {
                    myLinkList.findNode();
                }
                else if (input == "delete head")
                {
                    myLinkList.removeFirst();
                }
                else if (input == "delete tail")
                {
                    myLinkList.removeLast();
                }
                else if (input == "replace")
                {
                    myLinkList.replaceNode();
                }
                else if (input == "show")
                {
                    myLinkList.iterateForward();
                }
                else if (input == "create binary tree")
                {
                    Random rnd = new Random();
                    int num;
                    Console.Write("Enter in initial binary tree value: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    newTree = new Tree(num);
                    int counter = 10;
                    int n = counter;
                    //add node to tree and loop 10 times
                    for (int i = 1; i < n; i++)
                    {
                        counter--;
                        Console.Write("Enter a number (slots remaining {0}): ", counter);
                        num = Convert.ToInt32(Console.ReadLine());
                        newTree.Add(num);
                    }
                    string output = "";
                    newTree.Print(null, ref output);
                    Console.Write("Sorted Binary Tree: ");
                    Console.WriteLine(output);
                    Console.Write("Enter a node to delete: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    newTree.Delete(num);
                    output = "";
                    newTree.Print(null, ref output);
                    Console.WriteLine(output);
                }
                else if (input == "show reverse")
                {
                    myLinkList.iterateBackward();
                }
                else if (input == "add head")
                {
                    Console.Write("Enter in value to add: ");
                    string headinput;
                    headinput = Console.ReadLine();
                    myLinkList.addHead(headinput);
                }
                else if (input == "add tail")
                {
                    Console.Write("Enter in value to add: ");
                    string headinput;
                    headinput = Console.ReadLine();
                    myLinkList.addLast(headinput);
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
}

