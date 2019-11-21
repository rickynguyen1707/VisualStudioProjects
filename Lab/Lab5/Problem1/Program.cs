using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            string choice;

            Console.WriteLine("Enter a menu choice");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    message = "Calculate area";
                    break;
                case "2":
                    message = "Calculate volume";
                    break;
                case "3":
                    message = "Calculate surface area";
                    break;
                case "4":
                    message = "Exit the program";
                    break;
                default:
                    message = "ERROR: Invalid choice";
                    break;

            }
            Console.WriteLine(message);
        }
    }
}
