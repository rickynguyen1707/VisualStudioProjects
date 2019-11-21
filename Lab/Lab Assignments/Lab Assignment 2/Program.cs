using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double rateOfApplication;
            double unitPrice;
            double sizeOfLand;
            string userInput;

            Console.Write("What is the rate of fertilizer application in kg/hectares? ");
            userInput=Console.ReadLine();
            rateOfApplication = Convert.ToDouble(userInput);
            Console.Write("What is the unit price of fertilizer in dollar/kg? ");
            userInput = Console.ReadLine();
            unitPrice = Convert.ToDouble(userInput);
            Console.Write("What is the size of the land in hectares? ");
            userInput = Console.ReadLine();
            sizeOfLand = Convert.ToDouble(userInput);
            Console.WriteLine($"The cost to fertilize the land is {rateOfApplication * unitPrice * sizeOfLand}.");



        }
    }
}
