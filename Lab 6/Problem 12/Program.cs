using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyPayRate;

            Console.WriteLine("Enter an hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            switch (hourlyPayRate)
            {
                case double rate when (rate < 5.65 || rate > 49.99):
                    Console.WriteLine("Enter a valid hourly pay rate: ");
                    hourlyPayRate = Convert.ToDouble(Console.ReadLine());
                    switch (hourlyPayRate)
                    {
                        case double ratetwo when (ratetwo < 5.65 || ratetwo > 49.99):
                            Console.WriteLine("ERROR");
                            break;
                        default:
                            Console.WriteLine($"Hourly rate is {hourlyPayRate:c} and weekly pay rate is {hourlyPayRate * 40:c}");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"Hourly rate is {hourlyPayRate:c} and weekly pay rate is {hourlyPayRate * 40:c}");
                    break;
            }
        }
    }
}
