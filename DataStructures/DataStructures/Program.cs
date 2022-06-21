// See https://aka.ms/new-console-template for more information

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
            Console.WriteLine("Welcome To Data Structures Problems");
            Console.WriteLine("\n1: Create Linked List \n2: Add Node \n3: Append Node \n4: Add Number In Between" +
            " \n5: Delete First Node \n6: Delete Last Node \n7: Search Node \n8: Add Specific Node " +
            "\n9: Delete Specific Node \n10: Sort");
            int num = Convert.ToInt32(Console.ReadLine());
            LinkedLists linkedLists = new LinkedLists();
            
            switch (num)
            {
                case 1:
                    //UC-1
                    Node node1 = new Node(56);
                    Node node2 = new Node(30);
                    Node node3 = new Node(70);
                    node1.next = node2;
                    node2.next = node3;
                    linkedLists.Head = node1;
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 2:
                    //////UC-2
                    linkedLists.AddNode(70);
                    linkedLists.AddNode(30);
                    linkedLists.AddNode(56);
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 3:
                    //////UC-3
                    linkedLists.AppendNode(56);
                    linkedLists.AppendNode(30);
                    linkedLists.AppendNode(70);
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 4:
                    ////UC-4
                    linkedLists.AppendNode(56);
                    linkedLists.AppendNode(70);
                    linkedLists.InsertNode(30, 56);
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 5:
                    ////UC-5
                    linkedLists.AppendNode(56);
                    linkedLists.AppendNode(30);
                    linkedLists.AppendNode(70);
                    Console.WriteLine("Delete First element");
                    linkedLists.DeleteNodeAtFirst();
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 6:
                    ////UC-6
                    linkedLists.AppendNode(56);
                    linkedLists.AppendNode(30);
                    linkedLists.AppendNode(70);
                    Console.WriteLine("Delete Last element");
                    linkedLists.DeleteNodeAtLast();
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 7:
                    ////UC-7
                    Node node56 = new Node(56);
                    Node node30 = new Node(30);
                    Node node70 = new Node(70);
                    node56.next = node30;
                    node30.next = node70;
                    linkedLists.Head = node56;
                    Console.WriteLine("Search For Node value 30");
                    linkedLists.Display();
                    if (linkedLists.Search(30))
                    {
                        Console.WriteLine("\nNode with value 30 is available in Linked list");
                    }
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 8:
                    //UC-8
                    Console.WriteLine("Add Node After Node value 30 ");
                    linkedLists.AppendNode(56);
                    linkedLists.AppendNode(30);
                    linkedLists.AppendNode(70);
                    linkedLists.InsertNode(40, 30);
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                case 9:
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
                    break;
                case 10:
                    //UC-10
                    linkedLists.AppendNode(56);
                    linkedLists.AppendNode(30);
                    linkedLists.AppendNode(40);
                    linkedLists.AppendNode(70);
                    linkedLists.sort();
                    linkedLists.Display();
                    Console.WriteLine("\n-------------------------------");
                    break;
                    default:
                    Console.WriteLine("Number entered is invaild");
                    break;
            }
            
        }
    }
}

//UC-10
//Ability to create Ordered Linked List in ascending order of data entered in following sequence 56, 30, 40,and 70
//- Refactor the code to create SortedLinkedList Class
//- Create Node that takes data that is Comparable
//- Perform Sorting during the add method call
//- Final Sequence: 30->40->56->70

//Result
//Added 56 at start of the linkedlist
//Added 30 at start of the linkedlist
//Added 40 at start of the linkedlist
//Added 70 at start of the linkedlist
// Linked List :
//30-> 40-> 56-> 70
