// Nguyen Khang Nguyen - Student ID: 301098234

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyPayRate;

            Console.WriteLine("What is the hourly pay rate?");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyPayRate < 7.50 || hourlyPayRate > 49.99)
                Console.WriteLine("Error");
            else Console.WriteLine("The rate is okay");
        }
    }
}
