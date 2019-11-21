using System;
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
            int years;

            Console.Write("Enter the number of years money was left in the bank: ");
            years = Convert.ToInt32(Console.ReadLine());
            if (years >= 5)
                Console.WriteLine("Your interest rate is 7.5%");
            else Console.WriteLine("Your interest rate is 5.4%");
        }
    }
}
