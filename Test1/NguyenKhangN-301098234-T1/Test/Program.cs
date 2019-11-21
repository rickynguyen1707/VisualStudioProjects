// Nguyen Khang Nguyen - Student ID: 301098234

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double testOne = 86.5;
            double testTwo = 95.25;
            double testThree = 100;
            double testFour = 90.75;
            double testFive = 85;
            double average;

            average = (testOne + testTwo + testThree + testFour + testFive) / 5;
            Console.WriteLine($"The average of the test scores is {average}");


        }
    }
}
