using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double produceWeight;
            double producePrice;
            double bagPrice;
            double bagCapacity;
            string userInput;

            Console.Write("What is the weight of the produce? ");
            userInput = Console.ReadLine();
            produceWeight = Convert.ToDouble(userInput);
            Console.Write("What is the price of the produce? ");
            userInput = Console.ReadLine();
            producePrice  = Convert.ToDouble(userInput);
            Console.Write("What is the price of plastic bag? ");
            userInput = Console.ReadLine();
            bagPrice = Convert.ToDouble(userInput);
            Console.Write("What is the capacity of plastic bag? ");
            userInput = Console.ReadLine();
            bagCapacity  = Convert.ToDouble(userInput);
            Console.WriteLine($"The total price of grocery is {producePrice * produceWeight + (produceWeight / bagCapacity) * bagPrice} dollars.");
        }
    }
}
