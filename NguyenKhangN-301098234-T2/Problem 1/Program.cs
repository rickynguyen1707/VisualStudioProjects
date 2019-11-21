// Nguyen Khang Nguyen - Student ID: 301098234
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
            int userInput;
            int smallestNumber;
            int numberOfValues;
            int counter=0;

            Console.WriteLine("Enter the number of values you want to intput: ");
            numberOfValues = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number:");
            userInput = Convert.ToInt32(Console.ReadLine());
            smallestNumber = userInput;
            while(counter < numberOfValues-1)
            {
                Console.WriteLine("Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < smallestNumber)
                {
                    smallestNumber = userInput;
                }
                counter++;
            
            }
            Console.WriteLine($"The smallest number is {smallestNumber}");
            
        }
    }
}
