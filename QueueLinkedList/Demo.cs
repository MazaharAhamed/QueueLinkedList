using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLinkedList
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;

            QueueL quL = new QueueL();

            while(true)
            {
                Console.WriteLine("1.Queue Size");
                Console.WriteLine("2.Insert Element in Queue");
                Console.WriteLine("3.Delete Element in Queue");
                Console.WriteLine("4.Front Element in Queue");
                Console.WriteLine("5.Display all elements of Queue");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter Your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Size of Queue is: " + quL.Size());
                        break;
                    case 2:
                        Console.WriteLine("Enter element to insert:");
                        x = Convert.ToInt32(Console.ReadLine());
                        quL.Insert(x);
                        break;
                    case 3:
                        Console.WriteLine("Deleted Element is: "+quL.Delete());
                        break;
                    case 4:
                        Console.WriteLine("Front Element in Queue is: " + quL.Peek());
                        break;
                    case 5:
                        quL.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
