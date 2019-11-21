using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber;
            string secondNumber;

            Console.WriteLine("Hi, what is the first number?");
            firstNumber = Console.ReadLine();

            Console.WriteLine("Hi, what is the second number?");
            secondNumber = Console.ReadLine();

            Console.Write(firstNumber);
            Console.Write("+");
            Console.Write(secondNumber);
            Console.Write("=");
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
