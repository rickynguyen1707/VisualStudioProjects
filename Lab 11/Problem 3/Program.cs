using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };


            Console.WriteLine($"sum is {AddElements(primes)}");


        }
        static int AddElements(int[] anArray)
        {
            int sum = 0;

            for (int i = 0; i < anArray.Length; i++)
            {
                sum += anArray[i];
            }
            return sum;
        }
    }
}
