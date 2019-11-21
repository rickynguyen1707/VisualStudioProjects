using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = primes[i] * 2;
                Console.Write($"{primes[i]} ");
            }
        }
    }
}
