using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double fuelEfficiency;
            double fuelUnitPrice;
            double lengthOfJourney;
            string userInput;

            Console.Write("What is the fuel efficiency of the aircraft? ");
            userInput = Console.ReadLine();
            fuelEfficiency = Convert.ToDouble(userInput);
            Console.Write("What is the unit price of fuel? ");
            userInput = Console.ReadLine();
            fuelUnitPrice = Convert.ToDouble(userInput);
            Console.Write("What is the length of the journey? ");
            userInput = Console.ReadLine();
            lengthOfJourney = Convert.ToDouble(userInput);
            Console.WriteLine($"The total cost of flying an aircraft between various locations is {fuelEfficiency * lengthOfJourney * fuelUnitPrice} dollars.");


        }
    }
}
