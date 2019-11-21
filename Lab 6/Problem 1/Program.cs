using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;

            Console.WriteLine("Choose a choice");
            menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Calculate area");
                    break;
                case 2:
                    Console.WriteLine("Calculate volume");
                    break;
                case 3:
                    Console.WriteLine("Calculate surface area");
                    break;
                case 0:
                    Console.WriteLine("Exit the program");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid choice");
                    break;
            }
            
              
        }
    }
}
