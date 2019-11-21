using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double e;

            Console.WriteLine("Enter a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter e");
            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{true || false}");


        }
    }
}
