using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingDecisionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            double firstNumber;
            double secondNumber;

            Console.WriteLine("Enter operation");
            operation = Console.ReadLine();
            Console.WriteLine("Enter first number");
            firstNumber  = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber  = Convert.ToDouble(Console.ReadLine());
            if (operation == "+")
                Console.WriteLine($"The sum of two numbers is {firstNumber + secondNumber}");
            else
                Console.WriteLine($"First number subtract by second number is {firstNumber - secondNumber }");

        }
    }
}
