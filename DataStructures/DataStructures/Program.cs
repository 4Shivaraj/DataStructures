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
            Console.WriteLine("\n-------------------------------");

            //UC-2
            linkedLists.AddNode(70);
            linkedLists.AddNode(30);
            linkedLists.AddNode(56);
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");

        }
    }
}

// UC - 2
//Ability to create Linked
//List by adding 30 and 56 to 70

//- Node with data 70 is First Created
//- Next 30 is added to 70
//- Finally 56 is added to 30
//- LinkedList Sequence: 56->30->70

//Result
//Added 70 at start of the linkedlist
//Added 30 at start of the linkedlist
//Added 56 at start of the linkedlist
//Linked List:
//56-> 30-> 70