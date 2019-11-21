using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests;
            double average;
            int sum = 0;
            int noOfTests;

            Console.WriteLine("How many tests?");
            noOfTests = Convert.ToInt32(Console.ReadLine());

            tests = new int[noOfTests];
            for(int i=0; i<noOfTests; i++)
            {
                Console.WriteLine($"What is the score for test {i + 1}");
                tests[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i=0; i<noOfTests; i++)
            {
                Console.WriteLine($"Test {i + 1} score is {tests[i]}");
                sum += tests[i];
            }
            //for (int i = 0; i < tests.Length; i++)
            //{
            //    sum += tests[i];
            //}
            average = (double)sum / tests.Length;

            Console.WriteLine(average);
        }
    }
}
