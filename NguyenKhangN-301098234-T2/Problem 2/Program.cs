// Nguyen Khang Nguyen - Student ID: 301098234
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
            int userInput;
            int digit;

            Console.WriteLine("Enter an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            do
            {
                digit = userInput % 10;
                userInput = (userInput - digit) / 10;
                Console.Write(digit);
            } while (userInput > 0);
        }
    }
}
