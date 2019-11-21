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
            int firstNumber;
            int secondNumber;
            string operation;

            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operation to be done: ");
            operation = Console.ReadLine();
            if (operation == "+")
                Console.WriteLine($"The sum of two numbers is {firstNumber + secondNumber}");
            else Console.WriteLine($"The difference of the two number is {firstNumber - secondNumber}");
        }
    }
}
