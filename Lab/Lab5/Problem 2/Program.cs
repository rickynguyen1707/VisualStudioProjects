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
            int firstInteger;
            int secondInteger;
            int result = 0;
            string character;


            Console.Write("Enter first integer ");
            firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer ");
            secondInteger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character ");
            character = Console.ReadLine();
            switch (character)
            {
                case "A":
                    result = firstInteger + secondInteger;
                    break;
                case "S":
                    result = firstInteger - secondInteger;
                    break;
                case "M":
                    result = firstInteger * secondInteger;
                    break;                                       
            }
            Console.WriteLine($"The result is {result}");

        }
    }
}
