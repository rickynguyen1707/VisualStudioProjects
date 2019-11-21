using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string userInput;
            bool isEqual;

            Console.WriteLine("Hi, what is the first number?");
            userInput = Console.ReadLine();
            firstNumber = Convert.ToDouble(userInput);

            Console.WriteLine("Hi, what is the second number?");
            userInput = Console.ReadLine();
            secondNumber = Convert.ToDouble(userInput);

            isEqual = firstNumber == secondNumber;
            Console.WriteLine($"{firstNumber} == {secondNumber} is {isEqual}");
        }
    }
}
