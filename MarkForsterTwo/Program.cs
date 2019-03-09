using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarkForsterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> myTasks = new LinkedList<string>();

            try
            {
                using (StreamReader sr = new StreamReader(@"c:\Users\dougc\testfile1.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string newTask = sr.ReadLine();
                        myTasks.AddLast(newTask); // tasks.Add(line)
                    }
                }
            }
            catch (FileNotFoundException) {; }

            //DisplayList(myTasks);
            bool quit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Task List");
                Console.WriteLine();
                Console.WriteLine(" 1. Add a task");
                Console.WriteLine(" 2. Display Task List");
                Console.WriteLine(" 3. modify items on the task list");
                Console.WriteLine(" 0. Quit");
                Console.Write("Select your item: ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    quit = true;
                }
                else if (input == "1")
                {
                    AddATask(myTasks);

                }
                else if (input == "2")
                {
                    DisplayList(myTasks);

                    //DisplayList(myTasks);
                }
                else if (input == "3") //********************************************************************************
                {            //*******************************************************************************************************
                             //*****************************************************************************************************


                    NewMethod(myTasks, input);
                


                //******************************************************************************************************************************
                //**********************************************************************************************************************************



                else
                {
                        Console.WriteLine("Invalid Input.. Please try again.");
                        Console.ReadKey();
                    }
                } while (!quit);

            using (StreamWriter sw = new StreamWriter(@"c:\Users\dougc\testfile1.txt"))
            {
                foreach (string newTask in myTasks) // for each task
                {
                    sw.WriteLine(newTask);  // write task to file
                }
                Console.ReadLine();

            }
            //edge of main method
        }

        private static void DisplayList(LinkedList<string> myTasks)
        {
            Console.Clear();
            Console.WriteLine("This is your task list:");
            Console.WriteLine();
            for (int i = 0; i < myTasks.Count; ++i)
            {
                Console.WriteLine($"{i + 1}.  {myTasks.ElementAt(i)}");  //Adding task number**

            }
            Console.Write("\nPress any key for the main menu.");
            Console.ReadKey();
        }

        private static void AddATask(LinkedList<string> myTasks)
        {
            Console.Write("Enter your task: ");
            string newTask = Console.ReadLine();
            myTasks.AddLast(newTask);
            Console.WriteLine("You've added " + newTask + " to the task list.");

            while (newTask != "")
            {
                Console.WriteLine();
                Console.Write("Add another item to your list:");
                newTask = Console.ReadLine();
                if (newTask != "")
                {
                    myTasks.AddLast(newTask);
                }
                else
                { }
            }
        }

            //private static void ModifyTasks(List<string> tasks)
            //{

            //}
            //private static void MarkComplete(List<string> tasks)
            //{
            //    Console.WriteLine("Which item would you like to mark complete? ");
            //    int item = int.Parse(Console.ReadLine());
            //    int i = item - 1;
            //    Console.ReadLine();

            //    //tasks[0] += "new task"; **********************************************

            //    for (i = 0; i < tasks.Count; ++i)
            //    {
            //        if (i > 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkGray;
            //            Console.WriteLine(tasks[i]);
            //        }
            //        //Console.WriteLine(tasks[i]);
            //        Console.ResetColor();
            //    }
            //    //Console.ForegroundColor = ConsoleColor.White;
            //}
            //private static void DeleteItem(List<string> tasks)
            //{

    }

        private static void NewMethod(LinkedList<string> myTasks, string input)
        {
            Console.Clear();
            Console.WriteLine("**** This is your list of Tasks****");
            for (int i = 0; i < myTasks.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {myTasks.ElementAt(i)}"); // First display of list in ModifyTasks method*****
            }
            bool quit = false;

            do
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" 1. Delete a task");
                Console.WriteLine(" 2. Edit a Task");
                Console.WriteLine(" 3. Mark task complete");
                Console.WriteLine(" 0. Quit");
                string newTask = Console.ReadLine();

                if (input == "0")
                {
                    quit = true;
                }
                else if (input == "1")
            {
            Console.Write("Which item would you like to delete? ");
            //Console.ReadLine();
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine("You selected task: " + item);
            Console.ReadLine();
                    int n = item - 1;

            myTasks.Remove(myTasks.ElementAt(item- 1)); 
            Console.WriteLine("**** This is your updated list of Tasks****");
            for (int i = 0; i < myTasks.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {myTasks.ElementAt(i)}"); 
            }
            Console.ReadLine();
        }








            }   
                    




                    else if (input == "2")
                {
                    Console.Write("Which item would you like to modify? ");
                    //Console.ReadLine();
                    int item = int.Parse(Console.ReadLine());
                    Console.WriteLine("You selected item: " + item);
                    Console.ReadLine();
                }
                else if (input == "3")
                {
                    //MarkComplete(tasks);
                }
            } while (!quit);
        }
    }
public class GenericList<T>
{
    private class Node
    {
        public Node Next;
        public T Data;
    }
    private Node head = null;
    public void AddNode(T t)
    {
        Node newNode = new Node();
        newNode.Next = head;
        newNode.Data = t;
        head = newNode;
    }
    public T GetLast()
    {
        T temp = default(T);
        Node current = head;
        while (current != null)
        {
            temp = current.Data;
            current = current.Next;
        }
        return temp;
    }
}
