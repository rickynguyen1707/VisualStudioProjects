using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string userInput;


            Console.WriteLine("Hi, what is the first number?");
            userInput = Console.ReadLine();
            firstNumber = Convert.ToDouble(userInput);

            Console.WriteLine("Hi, what is the second number?");
            userInput = Console.ReadLine();
            secondNumber = Convert.ToDouble(userInput);

            //Console.Write(firstNumber);
            //Console.Write("+");
            //Console.Write(secondNumber);
            //Console.Write("=");
            //Console.WriteLine(firstNumber + secondNumber);

            Console.WriteLine($"{ firstNumber}+{ secondNumber}={ firstNumber+secondNumber}");

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
