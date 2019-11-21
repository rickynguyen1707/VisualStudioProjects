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
            int month;
            int day;

            Console.Write("Enter a month (use a 1 for Jan, etc.): ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day of the month: ");
            day = Convert.ToInt32(Console.ReadLine());
            if (month > 12 || month < 1)
                Console.WriteLine("Invalid month has been entered");
            if (day > 31 || day < 1)
                Console.WriteLine("Invalid day has been entered");
        }
    }
}
