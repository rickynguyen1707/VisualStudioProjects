using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyPayRate;
            double hoursWorked;
            double grossPay;

            Console.Write("Enter the hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            grossPay = hourlyPayRate * hoursWorked;
            Console.WriteLine($"Your gross pay is {grossPay:c}");
            if (grossPay  <= 300)
            {
                Console.WriteLine("Tax Withholding Percentage: 10%");
                Console.WriteLine($"Net pay: {grossPay - grossPay * 10 / 100:c}");
            }
            else
            {
                Console.WriteLine("Tax Withholding Percentage: 12%");
                Console.WriteLine($"Net pay: {grossPay - grossPay * 12 / 100:c}");
            }
        }
    }
}
