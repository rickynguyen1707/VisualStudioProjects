﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            double aNumber;

            Console.WriteLine("Please input a number");
            aNumber = Convert.ToDouble(Console.ReadLine());
            if (aNumber > 50)
            {
                Console.WriteLine($"{aNumber} > 50");
                Console.WriteLine("Done comparing");
            }
            else if (aNumber == 50) 
            {
                Console.WriteLine($"{aNumber} = 50");
            }    
            else
            {
                Console.WriteLine($"{aNumber} < 50");
            }
        }
    }
}
