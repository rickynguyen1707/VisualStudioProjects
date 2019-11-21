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
            double hoursWorked;

            Console.Write("Enter the number of hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            if (hoursWorked <= 40)
                Console.WriteLine($"You worked {hoursWorked}\nand earned {hoursWorked * 8:c}");
            else Console.WriteLine($"Your worked {hoursWorked}\nand earned {320 + (hoursWorked - 40) * 12:c}");

        }
    }
}
