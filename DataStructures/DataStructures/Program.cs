// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome To Data Structures Problems");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedLists = new LinkedLists();

            //UC-1
            //Node node1 = new Node(56);
            //Node node2 = new Node(30);
            //Node node3 = new Node(70);
            //node1.next = node2;
            //node2.next = node3;
            //linkedLists.Head = node1;
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            //////UC-2
            ////linkedLists.AddNode(70);
            ////linkedLists.AddNode(30);
            ////linkedLists.AddNode(56);
            ////linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            //////UC-3
            ////linkedLists.AppendNode(56);
            ////linkedLists.AppendNode(30);
            ////linkedLists.AppendNode(70);
            ////linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-4
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(70);
            //linkedLists.InsertNode(30, 56);
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-5
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //Console.WriteLine("Delete First element");
            //linkedLists.DeleteNodeAtFirst();
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-6
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //Console.WriteLine("Delete Last element");
            //linkedLists.DeleteNodeAtLast();
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            ////UC-7
            //Node node1 = new Node(56);
            //Node node2 = new Node(30);
            //Node node3 = new Node(70);
            //node1.next = node2;
            //node2.next = node3;
            //linkedLists.Head=node1;
            //Console.WriteLine("Search For Node value 30");
            //linkedLists.Display();
            //if (linkedLists.Search(30))
            //{
            //    Console.WriteLine("\nNode with value 30 is available in Linked list");
            //}
            //Console.WriteLine("\n-------------------------------");


            //UC-8
            //Console.WriteLine("Add Node After Node value 30 ");
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //linkedLists.InsertNode(40, 30);
            //linkedLists.Display();
            //Console.WriteLine("\n-------------------------------");

            //UC-9
            Console.WriteLine("Add Node After Node value 30 ");
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(40);
            linkedLists.AppendNode(70);
            Console.WriteLine("Before deleting:");
            linkedLists.Display();
            linkedLists.deleteNode(40);
            Console.WriteLine("\nAfter deleting:");
            linkedLists.Display();
            Console.WriteLine("\nSize of LinkedList is " + linkedLists.getCount());
            //Console.WriteLine("\n-------------------------------");

        }
    }
}

//UC-9
//Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3

//- Write MSTest Test Case as demonstrated in class
//-Search LinkedList to find node with key value 40
//- Delete the node
//- Implement size() and show the Linked List size is 3
//- Final Sequence: 56->30->70

//Result
//Add Node After Node value 30
//Added 56 at start of the linkedlist
//Added 30 at start of the linkedlist
//Added 40 at start of the linkedlist
//Added 70 at start of the linkedlist
//Before deleting:
// Linked List :
//56-> 30-> 40-> 70
//After deleting:
// Linked List :
//56-> 30-> 70
//Size of LinkedList is 3