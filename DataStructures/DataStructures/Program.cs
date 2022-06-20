// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome To Data Structures Problems");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Console.WriteLine("Welcome to Data Structures using Generics");
namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedLists = new LinkedLists();

            //UC-1
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            node1.next = node2;
            node2.next = node3;
            linkedLists.Head = node1;
            linkedLists.Display();

        }
    }
}

//UC-1
//Lets create a simple Linked List of 56, 30 and 70

//Result
//56 -> 30 -> 70