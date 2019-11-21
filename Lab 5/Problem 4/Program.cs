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
            double hourlyPayRate;

            Console.Write("Enter an hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyPayRate > 7.50 && hourlyPayRate < 49.99)
                Console.WriteLine($"Hourly pay rate is {hourlyPayRate:c}, weekly rate is {hourlyPayRate *40:c}");
            else
            {
                Console.Write("Enter a valid hourly pay rate ");
                hourlyPayRate = Convert.ToDouble(Console.ReadLine());
                if (hourlyPayRate > 7.50 && hourlyPayRate < 49.99)
                    Console.WriteLine($"Hourly pay rate is {hourlyPayRate:c}, weekly rate is {hourlyPayRate * 40:c}");
                else Console.WriteLine("ERROR");
            }
        }
    }
}
