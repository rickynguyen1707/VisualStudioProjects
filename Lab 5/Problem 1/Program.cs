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
            double hourlyPayRate;

            Console.Write("Enter an hourly pay rate ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyPayRate < 7.50)
                Console.WriteLine("Error");
        }
    }
}
