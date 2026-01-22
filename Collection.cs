using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {

        private class ListTask
        {
            private readonly List<string> _listOfStrings;

            public ListTask()
            {
                _listOfStrings = new List<string> { "Apple", "Banana", "Cherry" };
            }

            public void TaskLoop()
            {
                Console.WriteLine("Task 1: Enter strings. Type '-exit' to quit.");

                while (true)
                {
                    Console.WriteLine("\nCurrent list:");
                    for (int i = 0; i < _listOfStrings.Count; i++)
                        Console.WriteLine($"{i}: {_listOfStrings[i]}");

                    Console.Write("Enter a string to add at the end: ");
                    string input = Console.ReadLine();
                    if (input == "-exit") break;

                    _listOfStrings.Add(input);

                    Console.Write("Enter a string to add in the middle: ");
                    input = Console.ReadLine();
                    if (input == "-exit") break;

                    int middle = _listOfStrings.Count / 2;
                    _listOfStrings.Insert(middle, input);
                }

                Console.WriteLine("Exiting Task 1.");
            }
        }


        private class DictionaryTask
        {
            private readonly Dictionary<string, int> _students;

            public DictionaryTask()
            {
                _students = new Dictionary<string, int>();
            }

            public void TaskLoop()
            {
                Console.WriteLine("Task 2: Add student grades. Type '-exit' to quit.");

                while (true)
                {
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    if (name == "-exit") break;

                    int grade;
                    while (true)
                    {
                        Console.Write($"Enter grade for {name} (2-5): ");
                        string gradeInput = Console.ReadLine();
                        if (gradeInput == "-exit") return;

                        if (int.TryParse(gradeInput, out grade) && grade >= 2 && grade <= 5)
                            break;

                        Console.WriteLine("Invalid grade. Must be 2,3,4,5.");
                    }

                    _students[name] = grade;

                    Console.Write("Enter name to check grade: ");
                    string checkName = Console.ReadLine();
                    if (checkName == "-exit") break;

                    if (_students.ContainsKey(checkName))
                        Console.WriteLine($"{checkName}'s grade: {_students[checkName]}");
                    else
                        Console.WriteLine($"Student {checkName} not found.");
                }

                Console.WriteLine("Exiting Task 2.");
            }
        }


        private class LinkedListTask
        {
            private class Node
            {
                public string Value;
                public Node Next;
                public Node Prev;

                public Node(string value)
                {
                    Value = value;
                    Next = null;
                    Prev = null;
                }
            }

            private Node head;
            private Node tail;

            public void TaskLoop()
            {
                Console.WriteLine("Task 3: Doubly Linked List. Type '-exit' to quit.");

                int count = 0;
                while (count < 3 || count > 6)
                {
                    Console.Write("How many elements do you want to enter? (3-6): ");
                    string input = Console.ReadLine();
                    if (input == "-exit") return;

                    if (!int.TryParse(input, out count) || count < 3 || count > 6)
                        Console.WriteLine("Invalid number. Must be 3-6.");
                }

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    string val = Console.ReadLine();
                    if (val == "-exit") return;

                    Node newNode = new Node(val);
                    if (head == null)
                    {
                        head = tail = newNode;
                    }
                    else
                    {
                        tail.Next = newNode;
                        newNode.Prev = tail;
                        tail = newNode;
                    }
                }

                Console.WriteLine("\nList in order:");
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }

                Console.WriteLine("\nList in reverse order:");
                current = tail;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Prev;
                }

                Console.WriteLine("\nExiting Task 3.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1, 2 or 3 to run a task:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int task))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            switch (task)
            {
                case 1:
                    RunTask1();
                    break;
                case 2:
                    RunTask2();
                    break;
                case 3:
                    RunTask3();
                    break;
                default:
                    Console.WriteLine("Invalid task number.");
                    break;
            }
        }

        private static void RunTask1()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void RunTask2()
        {
            var dictTask = new DictionaryTask();
            dictTask.TaskLoop();
        }

        private static void RunTask3()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}