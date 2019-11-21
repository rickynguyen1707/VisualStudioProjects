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
            double a;
            double b;
            double c;
            double d;
            double p;
            double q;

            Console.Write("Enter value for a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value for b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value for c: ");
            c = Convert.ToDouble(Console.ReadLine());
            switch (a)
            {
                case double number when number == 0:
                    Console.WriteLine("Invalid input for a");
                    break;
                case double number when number != 0:
                    p = b*b - 4*a* c;
                    d = (-b) / (2 * a * p);
                    switch (d)
                    {
                        case double numbertwo when numbertwo >= 0:
                            q = Math.Sqrt(d) / (2 * a);
                            Console.WriteLine($"{p + q} , {p - q}");
                            break;
                        case double numbertwo when numbertwo < 0:
                            q = Math.Sqrt(-d) / (2 * a);
                            Console.WriteLine($"{p} + {q}i , {p} - {q}i");
                            break;
                    }
                    break;
            }
        }
    }
}
