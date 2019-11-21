using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            char operation;

            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operation: ");
            operation = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (operation)
            {
                case 'A':
                    Console.WriteLine($"The sum of two numbers is {firstNumber + secondNumber}");
                    break;
                case 'S':
                    Console.WriteLine($"The difference of two numbers is {firstNumber - secondNumber}");
                    break;
                case 'M':
                    Console.WriteLine($"The product of two numbers is {firstNumber * secondNumber}");
                    break;

            }
        }
    }
}
