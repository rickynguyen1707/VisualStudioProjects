using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyPayRate;
            double hoursWorked;
            double grossPay;
            const double below300Tax = 0.1;
            const double over300Tax = 0.12;

            Console.Write("Enter an hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            grossPay = hourlyPayRate * hoursWorked;
            switch (grossPay)
            {
                case double pay when pay <= 300:
                    Console.WriteLine($"Gross pay: {grossPay:c}\nWithholding tax: {grossPay * below300Tax:c}\nNet pay: {grossPay - grossPay * below300Tax:c}");
                    break;
                default: 
                    Console.WriteLine($"Gross pay: {grossPay:c}\nWithholding tax: {grossPay * over300Tax:c}\nNet pay: {grossPay - grossPay * over300Tax:c}");
                    break;
            }
        }
    }
}
