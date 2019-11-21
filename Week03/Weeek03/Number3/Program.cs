using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            string userInput;
            

            Console.WriteLine("Hi, what is the first number?");
            userInput = Console.ReadLine();
            firstNumber = Convert.ToInt32(userInput);

            Console.WriteLine("Hi, what is the second number?");
            userInput = Console.ReadLine();
            secondNumber = Convert.ToInt32(userInput);

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber + secondNumber);

            Console.Write(firstNumber);
            Console.Write("-");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber - secondNumber);

            Console.Write(firstNumber);
            Console.Write("*");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber * secondNumber);

            Console.Write(firstNumber);
            Console.Write(":");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
