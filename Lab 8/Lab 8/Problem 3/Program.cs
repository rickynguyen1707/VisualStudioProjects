﻿using System;
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
            int[] primes = {2,3,5,7,11,13,17,19};
            int sum = 0;
            for (int i=0; i < primes.Length; i++)
            {
                sum += primes[i];
            }
            Console.WriteLine(sum);
        }
    }
}
