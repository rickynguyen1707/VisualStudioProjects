using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double saleOfTickets;
            double broadcastingRights;
            double advertising;
            double centerRent;
            string userInput;

            Console.Write("What is the sale of tickets? ");
            userInput = Console.ReadLine();
            saleOfTickets = Convert.ToDouble(userInput);
            Console.Write("What is the broadcasting rights? ");
            userInput = Console.ReadLine();
            broadcastingRights = Convert.ToDouble(userInput);
            Console.Write("What is the advertising cost? ");
            userInput = Console.ReadLine();
            advertising = Convert.ToDouble(userInput);
            Console.Write("What is the rent of the Center? ");
            userInput = Console.ReadLine();
            centerRent = Convert.ToDouble(userInput);
            Console.WriteLine($"The profit that will result from hosting the event is {saleOfTickets + broadcastingRights + advertising - centerRent} dollars. ");


        }
    }
}
